Unreal CPP Project

# start project
- epic store
    - launch the unreal
    - select project
- unreal source build
    - build the unreal engine 
    - create a project
        - this will open new unreal engine editor and VS
    - click on the start without debug
    - once the editor is up start the live coding (ctrl + alt + f11)
        - if live coding is not starting then check editor preferences -> live coding (whether its enabled or not)
    - but once the editor is up - `DO NOT BUILD FROM VS`

## cpp errors in IntelliSense VS
- close the VS 
- `<project-name>`.uproject -> right click -> generate project files
- start the VS 

# plugins

## add
- first create a folder "Plugins"
- paste the content inside it
- project created from unreal source code build
    - `<project-name>`.uproject -> right click -> generate project files
    - this should be done everytime any header files are included
    - restart the VS 

## packaging
- before starting the package, add all the plugins
- add the plugins to `<project-name>`.uproject
```
{
	"FileVersion": 3,
	"EngineAssociation": "{BDC638EC-45BA-5023-6885-0BA624E5EF33}",
	"Category": "",
	"Description": "",
	"Modules": [
		{
			"Name": "UdmyOSubSysCppUSrc",
			"Type": "Runtime",
			"LoadingPhase": "Default"
		}
	],
	"Plugins": [
		{
			"Name": "ModelingToolsEditorMode",
			"Enabled": true,
			"TargetAllowList": [
				"Editor"
			]
		},
		{
            "Name": "OnlineSubsystem",
            "Enabled": true
        },
		{
            "Name": "OnlineSubsystemSteam",
            "Enabled": true
        }
	]
}
```
- <span style="color: red;">IMPORTANT</span> Run the build from VS before packaging
    - and not from the live coding

# Modules

## Live coding
- first start the unreal editor and then launch the VS IDE
- once the code is ready and if the live coding is not running - press - ctrl + shift + f11

## add modules
- in solution explorer
    - `<project name>`
        - source
            - `<project name>`
                - `<project name>`.Build.cs
- add to the PublicDependencyModuleNames.AddRange
    - "OnlineSubsystemSteam"
    - "OnlineSubsystem"

# online sub system
- enable the online subsystem Steam plugin for the unreal project
- keep the steam app running in the background
- package the game and then  only will connect to steam 
