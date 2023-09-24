SDK=17.0
SRC_FOLDER=SVProgressHUD-Xcode
PROJ_NAME=SVProgressHUD.xcodeproj
DLL_NAME=SVProgressHUD.dll
NATIVE_RELEASE=2.2.5
NUET_VERSION=2.2.5.1
SRC_FOLDER=SVProgressHUD-$(NATIVE_RELEASE)

all: prepare xcodebuild build clean
	
prepare:
	curl -L https://github.com/SVProgressHUD/SVProgressHUD/archive/$(NATIVE_RELEASE).zip | tar xz

xcodebuild:
	xcodebuild -project $(SRC_FOLDER)/$(PROJ_NAME) build -target SVProgressHUD -sdk iphonesimulator$(SDK) IPHONEOS_DEPLOYMENT_TARGET=7.0 EXCLUDED_ARCHS="arm64" 
	xcodebuild -project $(SRC_FOLDER)/$(PROJ_NAME) build -target SVProgressHUD -sdk iphoneos$(SDK) IPHONEOS_DEPLOYMENT_TARGET=7.0
	lipo -create $(SRC_FOLDER)/build/Release-iphoneos/libSVProgressHUD.a $(SRC_FOLDER)/build/Release-iphonesimulator/libSVProgressHUD.a -output libSVProgressHUD.a
	mkdir Resources
	cp -r $(SRC_FOLDER)/SVProgressHUD/SVProgressHUD.bundle Resources/SVProgressHUD.bundle
	
# Output bin/Release/DotNet/SVProgressHUD.dll
build:
	dotnet build -c Release SVProgressHUD.csproj
	
clean:
	rm -rf obj $(SRC_FOLDER) Resources *.a

clean-all:
	rm -rf *.nupkg

nuget:
	nuget pack SVProgressHUD.nuspec
	nuget push SVProgressHUD.$(NUET_VERSION).nupkg -Source nuget.org
