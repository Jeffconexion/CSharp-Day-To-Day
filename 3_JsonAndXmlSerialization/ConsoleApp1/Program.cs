using ConsoleApp1.Entitys;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

//----------------------------------------
// ~~> WORKING WITH JSON <~~
//----------------------------------------

var json = "{\"name\":\"John\", \"age\":30, \"car\":null}";

//----------------------------------------
// ~~> Convert json to object.
//----------------------------------------
var jsonObject = JsonConvert.DeserializeObject<People>(json);

//----------------------------------------
// ~~> Convert object to json
//----------------------------------------
var objectToJson = JsonConvert.SerializeObject(jsonObject);


//----------------------------------------
// ~~> WORKING WITH XML AND JSON <~~
//----------------------------------------

var xml = "<note>\r\n  <to>Tove</to>\r\n  <from>Jani</from>\r\n  <heading>Reminder</heading>\r\n  <body>Don't forget me this weekend!</body>\r\n</note>";
XmlDocument xmlConfig = new XmlDocument();
xmlConfig.LoadXml(xml);

//----------------------------------------
// ~~> Convert xml to json
//----------------------------------------
var jsonSchedule = JsonConvert.SerializeXmlNode(xmlConfig);

//----------------------------------------
// ~~> Convert json to object.
//----------------------------------------
var sheduleObject = JsonConvert.DeserializeObject<Shedule>(jsonSchedule);


//----------------------------------------
// ~~> Convert object to object.
//----------------------------------------
XmlSerializer serializer = new XmlSerializer(typeof(Shedule));
StringWriter record =new StringWriter();

serializer.Serialize(record, sheduleObject);
var objectToXml = record.ToString();


Console.WriteLine("Finish!");
Console.ReadKey();
