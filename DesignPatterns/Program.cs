using DesignPatterns.Essentials;
using DesignPatterns.IteratorPattern;
using DesignPatterns.BridgePattern.Solution;
using DesignPatterns.TemplatePattern.Solution;
using DesignPatterns.CommandPattern;
using DesignPatterns.AdapterPattern.Solution;
using DesignPatterns.DecoratorePattern.Solution;
using DesignPatterns.MementoPattern.Solution;
using DesignPatterns.StatePattern.Problem;
using DesignPatterns.FacadePattern.Solution;
using DesignPatterns.FlyWeightPattern.Solution;
using DesignPatterns.StrategyPattern.Solution;
using DesignPatterns.Observer.Solution;
using DesignPatterns.MediatorPattern.Solution;
using DesignPatterns.ChainOfResponsibility.Solution;
using DesignPatterns.VisitorPattern.Solution;



//use for Grouped class
#region Composite Pattern
Console.WriteLine("/***Proxy Composite***/");
//--------------------------------------Problem :
var group1 = new DesignPatterns.CompositePattern.Problem.Group();
group1.add(new DesignPatterns.CompositePattern.Problem.Shape());//square
group1.add(new DesignPatterns.CompositePattern.Problem.Shape());//square

var group2 = new DesignPatterns.CompositePattern.Problem.Group();
group2.add(new DesignPatterns.CompositePattern.Problem.Shape());//circle
group2.add(new DesignPatterns.CompositePattern.Problem.Shape());//circle

var group = new DesignPatterns.CompositePattern.Problem.Group();
group.add(group1);
group.add(group2);
group.render();
//--------------------------------------
//--------------------------------------solve : 
//DesignPatterns.CompositePattern.Solution.CompositePatternSample.Run();
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion

//use interface
#region Interface
ITaxCalculatore taxCalculatore2019 = new TaxCalculatore2019();
ITaxCalculatore taxCalculatore2020 = new TaxCalculatore2020();
#endregion

//use for create adapter to convert class
#region Adapter Pattern
Console.WriteLine("/***Adapter Pattern***/");
//--------------------------------------Problem :
//var imageView = new ImageView(new Image());
//imageView.apply(new VivedFilter());
//--------------------------------------
//--------------------------------------solve : 
var imageView = new ImageView(new Image());
imageView.apply(new VivedFilter());
imageView.apply(new CaramelFilter());
Console.WriteLine("/***********************/");
#endregion

//use for implement undo mechanism
#region Memento Pattern
Console.WriteLine("/***Memento Pattern***/");
//--------------------------------------Problem :
//var editor = new Editor();
//editor.content = "a";
//editor.content = "b";
//editor.content = "c";//How can implement undo? we can use Memento Pattern
//--------------------------------------
//--------------------------------------solve : 
var editor = new Editor();
var history = new History();
editor.content = "a";
history.push(editor.createState());
editor.content = "b";
history.push(editor.createState());
editor.content = "c";
history.pop();
Console.WriteLine("a is undo");
history.pop();
Console.WriteLine("b is undo");
history.push(editor.createState());
foreach (var item in history.states)
{
    Console.WriteLine($"Just {item.content} Remaning");
}
Console.WriteLine("/***********************/");
#endregion

//can add aditional behavior to an object 
#region Decoratore Pattern
Console.WriteLine("/***Decoratore Pattern***/");
//--------------------------------------Problem :
//var clds = new CloudStream();
//clds.write("asd");
//var ccs = new CompressedCloudStream();
//ccs.write("asd");
//var ecs = new EncryptedCloudStream();
//ecs.write("asd");
//--------------------------------------
//--------------------------------------solve : 
var clds = new CloudStream();
clds.write("asd");
var ecs = new EncryptedCloudStream(new CloudStream());
ecs.write("asd");
Console.WriteLine("/***********************/");
#endregion

//can add aditional behavior to an object 
#region State Pattern
Console.WriteLine("/***State Pattern***/");
//--------------------------------------Problem :
var canvas = new Canvas();
canvas.currentTool = ToolType.SELECTION;
canvas.mouseDown();
canvas.mouseUp();
//--------------------------------------
//--------------------------------------solve : 
//var canvas = new Canvas(new BrushTool());
//canvas.mouseDown();
//canvas.mouseUp();
Console.WriteLine("/***********************/");
#endregion

//
#region Facade Pattern
Console.WriteLine("/***Facade Pattern***/");
//--------------------------------------Problem : so many step to send message
//var server = new NotificationServer();
//var connection = server.connect("ip");
//var authToken = server.authenticate("appId", "key");
//var message = new Message("Hi amir");
//var target = "amir.mollaee1369@gmail.com";
//server.send(authToken,message,target);
//connection.disconnect();
//--------------------------------------
//--------------------------------------solve : put the step to into another class
var service = new NotificationService();
service.send("Hi amir", "amir.mollaee1369@gmail.com");
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion

//
#region Iterator Pattern
Console.WriteLine("/***Iterator Pattern***/");
var _history = new BrowseHistory();
_history.push("a");
_history.push("b");
_history.push("c");
//--------------------------------------Problem : if i change List to another type of list at BrowseHistory then must change all code bcz they have diff func
//for (var i = 0; i < _history.urls.Count; i++)
//{
//    Console.WriteLine(_history.urls[i]);
//}
//--------------------------------------
//--------------------------------------solve : wiht this implementation we dont care aboute list type
var iterator = _history.createIterator();
while (iterator.hasNext())
{
    Console.WriteLine(iterator.current());
    iterator.next();
}
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion

//we can reduce memory of the application uses
#region FlyWeight Pattern
Console.WriteLine("/***FlyWeight Pattern***/");
//--------------------------------------Problem : alot memory application uses (int:4b,array:20kb,...)
//var pointService = new PointService();
//foreach (var point in pointService.getPoints())
//{
//    point.draw();
//}
//--------------------------------------
//--------------------------------------solve : just one place uses to store point
var pointService = new PointService(new PointIconFactory());
foreach (var point in pointService.getPoints())
{
    point.draw();
}
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion

//
 #region Strategy Pattern
Console.WriteLine("/***Strategy Pattern***/");
//--------------------------------------Problem : if i make a class for storing file and compress and filter , single responcibility not correct
//var imageStorage = new ImageStorage("jpeg","b&w");
//imageStorage.store("index");
//--------------------------------------
//--------------------------------------solve : 
var imageStorage = new ImageStorage(
    new PNGCompressor(),
    new BlackAndWihteFilter()
    );
imageStorage.store("index");
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion

//
#region Bridge Pattern
Console.WriteLine("/***Bridge Pattern***/");
//--------------------------------------Problem : if i want to add another TV , i have to add two class(RemoteControl,AdvancedSonyRemoteControl)
//var sonyRemoteControl = new SonyRemoteControl();
//sonyRemoteControl.turnOn();
//--------------------------------------
//--------------------------------------solve : 
var remoteControl = new RemoteControl(new SonyDevice());
remoteControl.turnOff();
var remoteControl2 = new RemoteControl(new SamsungDevice());
remoteControl2.turnOff();
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion

//
#region Template Pattern
Console.WriteLine("/***Template Pattern***/");
//--------------------------------------Problem :in GenerateReport and TransferMoneyTask we have to repeat code(public AuditTrail auditTrail;)

//--------------------------------------
//--------------------------------------solve : 
var transferMoneyTask = new TransferMoneyTask(
    new AuditTrail()
    );

transferMoneyTask.execute();
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion

//
#region Command Pattern
Console.WriteLine("/***Command Pattern***/");
//--------------------------------------Problem :if we want to use button in alot place , we dont know how to implement click action

//--------------------------------------
//--------------------------------------solve : 
//Command Pattern
var customerService = new CustomerService();
var addCustomerCommand = new AddCustomerCommand(customerService);
var button = new DesignPatterns.CommandPattern.fx.Button(addCustomerCommand);
button.click();

//Composite Command Pattern
var compositeCommand = new CompositeCommand();
compositeCommand.add(new ResizeCommand());
compositeCommand.add(new BlackAndWhiteCommand());
compositeCommand.execute();

//Undoable Command Pattern
var historyCP=new DesignPatterns.CommandPattern.editor.History();
var document= new DesignPatterns.CommandPattern.editor.HtmlDocument();
document.content = "Hello World";
var boldCommand = new DesignPatterns.CommandPattern.editor.BoldCommand(
    document,historyCP
    );
boldCommand.execute();
Console.WriteLine(document.content);
boldCommand.unExecute();

var undoCommand = new DesignPatterns.CommandPattern.editor.UndoCommand(historyCP);
undoCommand.execute();
Console.WriteLine(document.content);
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion

//Lazy Loading
#region Proxy Pattern
Console.WriteLine("/***Proxy Pattern***/");
//--------------------------------------Problem :
//var library = new DesignPatterns.ProxyPattern.Problem.Library();
//string[] fileNames = new string[] {"a","b","c" };
//foreach (var fileName in fileNames)
//{
//    library.add(new DesignPatterns.ProxyPattern.Problem.Ebook(fileName));
//}

//library.openEbook("a");
//--------------------------------------
//--------------------------------------solve : 
var library = new DesignPatterns.ProxyPattern.Solution.Library();
string[] fileNames = new string[] { "a", "b", "c" };
foreach (var fileName in fileNames)
{
    //library.add(new DesignPatterns.ProxyPattern.Solution.EbookProxy(fileName));
    library.add(new DesignPatterns.ProxyPattern.Solution.LoggingEbookProxy(fileName));
}

library.openEbook("a");
library.openEbook("b");
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion

#region Observer Pattern
Console.WriteLine("/***Observer Pattern***/");
//--------------------------------------Problem :
//--------------------------------------
//--------------------------------------solve : 
var dataSource = new DataSource();
var spreadSheet1 = new SpreadSheet();
var spreadSheet2 = new SpreadSheet();
var chart=new Chart();

dataSource.addObserver(spreadSheet1);
dataSource.addObserver(spreadSheet2);
dataSource.addObserver(chart);

dataSource.setValue(1);
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion

#region Mediator Pattern
Console.WriteLine("/***Mediator Pattern***/");
//--------------------------------------Problem :
//--------------------------------------
//--------------------------------------solve : 
var dialog = new ArticleDialogBox();
dialog.simulateUserInteraction();
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion

#region Chain Of Responsibility Pattern
Console.WriteLine("/***Chain Of Responsibility Pattern***/");
//--------------------------------------Problem :
//--------------------------------------
//--------------------------------------solve : 
//Authenticate->Log->Compress
var compressor = new Compressor(null);
var logger=new Logger(compressor);
var authenticator = new Authenticator(logger);

var server=new WebServer(authenticator);
server.handle(new HttpRequest("admin", "123"));
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion

#region Visitor Pattern
Console.WriteLine("/***Visitor Pattern***/");
//--------------------------------------Problem :
//var documents = new HtmlDocument();
//documents.add(new HeadingNode());
//documents.add(new AnchorNode());
//documents.highlight();
//--------------------------------------
//--------------------------------------solve : 
var documents = new HtmlDocument();
documents.add(new HeadingNode());
documents.add(new AnchorNode());
documents.execute(new HighlightOpreation());
documents.execute(new PlainTextOperation());
//--------------------------------------
Console.WriteLine("/***********************/");
#endregion
