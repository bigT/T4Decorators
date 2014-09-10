param($installPath, $toolsPath, $package, $project)

$project.ProjectItems.Item("T4Decorators.tt").Properties.Item("BuildAction").Value = 0 #prjBuildActionNone
