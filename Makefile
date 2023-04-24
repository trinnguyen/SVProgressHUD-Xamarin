MSBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild
SDK=16.4
SRC_FOLDER=SVProgressHUD-Xcode
PROJ_NAME=SVProgressHUD.xcodeproj
DLL_NAME=SVProgressHUD.dll
NATIVE_RELEASE=2.2.5
SRC_FOLDER=SVProgressHUD-$(NATIVE_RELEASE)

all: prepare xcodebuild msbuild clean
	
prepare:
	curl -L https://github.com/SVProgressHUD/SVProgressHUD/archive/$(NATIVE_RELEASE).zip | tar xz

xcodebuild:
	xcodebuild -project $(SRC_FOLDER)/$(PROJ_NAME) build -target SVProgressHUD -sdk iphonesimulator$(SDK) IPHONEOS_DEPLOYMENT_TARGET=7.0 EXCLUDED_ARCHS="arm64" 
	xcodebuild -project $(SRC_FOLDER)/$(PROJ_NAME) build -target SVProgressHUD -sdk iphoneos$(SDK) IPHONEOS_DEPLOYMENT_TARGET=7.0
	lipo -create $(SRC_FOLDER)/build/Release-iphoneos/libSVProgressHUD.a $(SRC_FOLDER)/build/Release-iphonesimulator/libSVProgressHUD.a -output libSVProgressHUD.a
	mkdir Resources
	cp -r $(SRC_FOLDER)/SVProgressHUD/SVProgressHUD.bundle Resources/SVProgressHUD.bundle
	
msbuild:
	msbuild /p:Configuration=Release SVProgressHUD.csproj
	dotnet build -c Release SVProgressHUD.DotNet.csproj
	rm -rf build
	mkdir -p build/Xamarin
	mkdir -p build/DotNet
	cp bin/Release/Xamarin/$(DLL_NAME) build/Xamarin/$(DLL_NAME)
	cp bin/Release/DotNet/${DLL_NAME} build/DotNet/${DLL_NAME}
	
clean:
	rm -rf bin obj $(SRC_FOLDER) Resources *.a

clean-all:
	rm -rf build *.nupkg

nuget:
	nuget pack SVProgressHUD.nuspec
	nuget push SVProgressHUD.$(NATIVE_RELEASE).nupkg -Source nuget.org
