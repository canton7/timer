;NSIS Modern User Interface

;--------------------------------
;Include Modern UI

  !include "MUI2.nsh"

;--------------------------------
;General

  ;Name and file
  Name "Timer"
  OutFile "Timer.exe"
  Icon "..\icon.ico"

  ;Default installation folder
  InstallDir "$PROGRAMFILES\Timer"
  
  ;Get installation folder from registry if available
  InstallDirRegKey HKCU "Software\Timer" ""

  ;Request application privileges for Windows Vista
  RequestExecutionLevel admin

;--------------------------------
;Interface Settings

  !define MUI_ABORTWARNING

;--------------------------------
;Pages

  !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES
  
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES
  
;--------------------------------
;Languages
 
  !insertmacro MUI_LANGUAGE "English"

;--------------------------------
;Installer Sections

Section
  SetOutPath "$INSTDIR"

  File "..\bin\Release\timer.exe"

  File "..\bin\Release\timer.exe"
  File "..\bin\Release\LitJson.dll"
  File "..\alarm.wav"
  File "..\icon.ico"

  ;Store installation folder
  WriteRegStr HKCU "Timer" "" $INSTDIR

  ;Create uninstaller
  WriteUninstaller  "$INSTDIR\uninstall.exe"

SectionEnd

Section "Start Menu Shortcut" secStartMenu
  CreateShortCut "$SMPROGRAMS\Timer.lnk" "$INSTDIR\Timer.exe" "" "$INSTDIR\icon.ico"
SectionEnd

Section "Desktop Shortcut" secDesktop
  CreateShortCut "$DESKTOP\Timer.lnk" "$INSTDIR\Timer.exe" "" "$INSTDIR\icon.ico"
SectionEnd

;--------------------------------
;Descriptions

  ;Language strings
  ;LangString DESC_secStartMenu ${LANG_ENGLISH} "Add a link in the start menu"

  ;Assign language strings to sections
  ;!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
  ;  !insertmacro MUI_DESCRIPTION_TEXT ${SecDummy} $(DESC_SecDummy)
  ;!insertmacro MUI_FUNCTION_DESCRIPTION_END

;--------------------------------
;Uninstaller Section

Section "Uninstall"

  ;ADD YOUR OWN FILES HERE...
  Delete "$INSTDIR\Timer.exe"
  Delete "$INSTDIR\LitJson.dll"
  Delete "$INSTDIR\icon.ico"
  Delete "$INSTDIR\alarm.wav"

  Delete "$SMPROGRAMS\Timer.lnk"
  Delete "$DESKTOP\Timer.lnk"

  Delete "$INSTDIR\uninstall.exe"

  RMDir "$INSTDIR"

  Delete "$LOCALAPPDATA\Timer\tasks.json"
  RMDir "$LOCALAPPDATA\Timer"

  DeleteRegKey /ifempty HKCU "Software\Timer"

SectionEnd