MSBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild
SDK=9.2
SRC_FOLDER=SVProgressHUD-Xcode
PROJ_NAME=SVProgressHUD.xcodeproj
DLL_NAME=SVProgressHUD.dll

all: prepare xbuild clean
	
prepare:
	git clone https://github.com/SVProgressHUD/SVProgressHUD.git $(SRC_FOLDER)
	xcodebuild -project $(SRC_FOLDER)/$(PROJ_NAME) build -target SVProgressHUD -sdk iphonesimulator$(SDK) -arch i386
	xcodebuild -project $(SRC_FOLDER)/$(PROJ_NAME) build -target SVProgressHUD -sdk iphoneos$(SDK)
	lipo -create $(SRC_FOLDER)/build/Release-iphoneos/libSVProgressHUD.a $(SRC_FOLDER)/build/Release-iphonesimulator/libSVProgressHUD.a -output libSVProgressHUD.a
	mkdir Resources
	cp -r $(SRC_FOLDER)/SVProgressHUD/SVProgressHUD.bundle Resources/SVProgressHUD.bundle
	
xbuild:
	xbuild /p:Configuration=Release
	rm -rf build
	mkdir build
	cp bin/Release/$(DLL_NAME) build/$(DLL_NAME)
	
clean:
	rm -rf bin obj $(SRC_FOLDER) Resources *.a