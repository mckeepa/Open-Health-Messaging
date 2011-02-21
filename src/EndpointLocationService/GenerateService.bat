
svcutil /t:code /out:els-Lookup-Interface-2010.cs /n:*,OpenHealthMessaging.EndpointLocationService.Lookup /UseSerializerForFaults wsdl\els-Lookup-Interface-2010.wsdl xsd\*.xsd /config:els-Lookup-Interface-2010.config /reference:..\CommonDataTypes\bin\Debug\OpenHealthMessaging.CommonDataTypes.dll


rem svcutil /dconly /t:code /out:.\CommonDataTypes\els-DataTypes-2010.cs  /n:*,Open-Health-Messaging.CommonDataTypes /UseSerializerForFaults xsd\els-DataTypes-2010.xsd /reference:..\CommonDataTypes\bin\Debug\OpenHealthMessaging.CommonDataTypes.dll





rem svcutil /t:code /out:els-Lookup-Interface-2010.cs /n:*,OpenHealthMessaging.EndpointLocationService.Lookup /UseSerializerForFaults wsdl\els-Lookup-Interface-2010.wsdl xsd\*.xsd /config:els-Lookup-Interface-2010.config /reference:..\CommonDataTypes\bin\Debug\OpenHealthMessaging.CommonDataTypes.dll
rem svcutil /t:code /out:els-Publish-Interface-2010.cs /n:*,Open-Health-Messaging.EndpointLocationService.Publish /UseSerializerForFaults wsdl\els-Publish-Interface-2010.wsdl xsd\*.xsd /config:els-Publish-Interface-2010.config /reference:..\..\..\..\build\bin\CommonDataTypes.dll



