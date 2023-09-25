SDK=17.0
SRC_FOLDER=SVProgressHUD-Xcode
PROJ_NAME=SVProgressHUD.xcodeproj
DLL_NAME=SVProgressHUD.dll
NATIVE_RELEASE=2.2.5
NUGET_VERSION=2.2.5.3
SRC_FOLDER=SVProgressHUD-$(NATIVE_RELEASE)

all: prepare xcodebuild build pack clean
	
prepare:
	curl -L https://github.com/SVProgressHUD/SVProgressHUD/archive/$(NATIVE_RELEASE).zip | tar xz

xcodebuild:
	xcodebuild -project $(SRC_FOLDER)/$(PROJ_NAME) build -target SVProgressHUD -sdk iphonesimulator$(SDK) IPHONEOS_DEPLOYMENT_TARGET=12.0 EXCLUDED_ARCHS="arm64"
	xcodebuild -project $(SRC_FOLDER)/$(PROJ_NAME) build -target SVProgressHUD -sdk iphoneos$(SDK) IPHONEOS_DEPLOYMENT_TARGET=12.0
	lipo -create $(SRC_FOLDER)/build/Release-iphoneos/libSVProgressHUD.a $(SRC_FOLDER)/build/Release-iphonesimulator/libSVProgressHUD.a -output ./libSVProgressHUD.a
	lipo -info ./libSVProgressHUD.a
	mkdir Resources
	cp -r $(SRC_FOLDER)/SVProgressHUD/SVProgressHUD.bundle Resources/SVProgressHUD.bundle
	
# Output: bin/Release/SVProgressHUD.dll
build:
	dotnet build -c Release SVProgressHUD.csproj
	
clean:
	rm -rf obj $(SRC_FOLDER) Resources *.a

pack:
	dotnet pack -c Release SVProgressHUD.csproj

nuget:
	nuget push bin/Release/SVProgressHUD.${NUGET_VERSION}.nupkg -Source nuget.org