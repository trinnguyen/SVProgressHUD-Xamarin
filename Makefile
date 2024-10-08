SDK=18.0
SRC_FOLDER=SVProgressHUD-Xcode
PROJ_NAME=SVProgressHUD.xcodeproj
DLL_NAME=SVProgressHUD.dll
NATIVE_RELEASE=2.3.1
SRC_FOLDER=SVProgressHUD-$(NATIVE_RELEASE)

all: clean prepare xcodeframework xcodecreate build pack clean
	
prepare:
	curl -L https://github.com/SVProgressHUD/SVProgressHUD/archive/$(NATIVE_RELEASE).zip | tar xz

xcodebuild:
	xcodebuild -project $(SRC_FOLDER)/$(PROJ_NAME) build -target SVProgressHUD -sdk iphonesimulator$(SDK) IPHONEOS_DEPLOYMENT_TARGET=12.0
	xcodebuild -project $(SRC_FOLDER)/$(PROJ_NAME) build -target SVProgressHUD -sdk iphoneos$(SDK) IPHONEOS_DEPLOYMENT_TARGET=12.0
	lipo -create $(SRC_FOLDER)/build/Release-iphoneos/libSVProgressHUD.a $(SRC_FOLDER)/build/Release-iphonesimulator/libSVProgressHUD.a -output ./libSVProgressHUD.a
	lipo -info ./libSVProgressHUD.a
	mkdir Resources
	cp -r $(SRC_FOLDER)/SVProgressHUD/SVProgressHUD.bundle Resources/SVProgressHUD.bundle

xcodeframework:
	xcodebuild build -project $(SRC_FOLDER)/$(PROJ_NAME) -scheme SVProgressHUD-Framework -destination "generic/platform=iOS" -configuration Release -derivedDataPath build
	xcodebuild build -project $(SRC_FOLDER)/$(PROJ_NAME) -scheme SVProgressHUD-Framework -destination "generic/platform=iOS Simulator" -configuration Release -derivedDataPath build

xcodecreate:
	rm -rf SVProgressHUD.xcframework
	xcodebuild -create-xcframework -framework build/Build/Products/Release-iphonesimulator/SVProgressHUD.framework -framework build/Build/Products/Release-iphoneos/SVProgressHUD.framework -output ./SVProgressHUD.xcframework
	mkdir Resources
	cp -r $(SRC_FOLDER)/SVProgressHUD/SVProgressHUD.bundle Resources/SVProgressHUD.bundle
	
# Output: bin/Release/SVProgressHUD.dll
build:
	dotnet build -c Release SVProgressHUD.csproj
	
clean:
	rm -rf Resources
	rm -rf obj $(SRC_FOLDER)
	rm -rf build
	rm -rf Resources

pack:
	dotnet pack -c Release SVProgressHUD.csproj

nuget:
	dotnet nuget push bin/Release/*.nupkg -k ${NUGET_API_KEY} -s https://api.nuget.org/v3/index.json