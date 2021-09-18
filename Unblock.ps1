$scriptPath = split-path -parent $MyInvocation.MyCommand.Definition
dir $scriptPath -Recurse | Unblock-File