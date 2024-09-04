using static System.Net.WebRequestMethods;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var app = builder.Build();



app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}"
);
app.Run();

/* 
-Kavramlar-

ontroller:
Tanım: MVC(Model - View - Controller) tasarım deseninde, kullanıcıdan gelen istekleri işleyen ve uygun yanıtları döndüren sınıflardır.
Amaç: Kullanıcıların web uygulamasıyla etkileşimini yönetir ve iş mantığını uygulamalarına yardımcı olur.

Action:
Tanım: Bir Controller sınıfında tanımlanan ve belirli bir URL isteğine yanıt veren yöntemlerdir.
Amaç: HTTP isteklerini işlemek ve sonuçları View'a veya başka bir yanıt formatına dönüştürmek için kullanılır.

Model:
Tanım: Verileri ve iş mantığını temsil eden sınıflardır. Genellikle veritabanı ile etkileşimde bulunur.
Amaç: Uygulamanın veri yapısını ve iş mantığını tanımlar. Veriyi işlemek ve taşımak için kullanılır.

View:
Tanım: Kullanıcıya gösterilecek HTML içeriğini tanımlayan şablonlardır.
Amaç: Modelden gelen verileri kullanarak kullanıcı arayüzünü oluşturur.

Razor:
Tanım: ASP.NET Core'un dinamik HTML şablonları oluşturmak için kullanılan bir motorudur.
Amaç: C# kodunu HTML içinde gömülü olarak yazmak ve çalıştırmak için kullanılır.

RazorView:
Tanım: Razor motoru tarafından işlenen ve dinamik HTML içeriği oluşturan dosyalardır (genellikle .cshtml uzantılı).
Amaç: Controller'dan gelen verileri kullanarak HTML içeriği oluşturur ve tarayıcıya gönderir.

wwwroot:
Tanım: ASP.NET Core uygulamasında, statik dosyaların (CSS, JavaScript, resimler vb.) bulunduğu kök dizindir.
Amaç: Web sunucusu tarafından doğrudan erişilebilir dosyaların saklandığı yerdir.

-Metotlar-
builder.Build():
Tanım: ASP.NET Core uygulamasını yapılandırmak için kullanılan bir yöntemdir.
Amaç: Uygulamanın yapılandırmasını tamamlar ve çalıştırılabilir bir WebApplication örneği oluşturur.

app.Run():
Tanım: WebApplication nesnesinin çalıştırılmasını başlatan bir yöntemdir.
Amaç: Uygulamayı başlatır ve HTTP isteklerini dinlemeye başlar. Genellikle en son konfigürasyon işlemlerinden sonra çağrılır ve uygulamanın çalışmasını sağlar.*/