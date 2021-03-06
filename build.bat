:: Generated by: https://github.com/swagger-api/swagger-codegen.git
::
:: Licensed under the Apache License, Version 2.0 (the "License");
:: you may not use this file except in compliance with the License.
:: You may obtain a copy of the License at
::
::      http://www.apache.org/licenses/LICENSE-2.0
::
:: Unless required by applicable law or agreed to in writing, software
:: distributed under the License is distributed on an "AS IS" BASIS,
:: WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
:: See the License for the specific language governing permissions and
:: limitations under the License.

@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319


if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/v3.3.0/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\pb.locationIntelligence\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.8.0.3\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\RestSharp.105.1.0\lib\net45\RestSharp.dll bin\RestSharp.dll
copy packages\ILMerge.2.14.1208\tools\ILMerge.exe bin\ILMerge.exe
%CSCPATH%\csc -nowarn:0109,1591,1573 /reference:bin\Newtonsoft.Json.dll;bin\RestSharp.dll /target:library /out:bin\LocationIntelligenceCSharpSDK-8.5.0.dll /recurse:src\pb.locationIntelligence\*.cs /doc:bin\pb.locationIntelligence.xml
cd bin
mkdir comb
ilmerge /out:comb/LocationIntelligenceCSharpSDK-8.5.0.dll Newtonsoft.Json.dll RestSharp.dll LocationIntelligenceCSharpSDK-8.5.0.dll
exit 0




