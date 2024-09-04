ASP.NET CORE MVC PROJESİ

Bu rehber, ASP.NET Core Empty projesinde MVC tasarım desenine uygun yapıları nasıl ekleyip yapılandıracağınızı açıklar.

Proje Yapılandırması

Klasörlerin Oluşturulması
Projenizin kök dizininde aşağıdaki klasörleri oluşturun:

Controllers: MVC Controller'larınızı içerecek.
Models: Uygulamanızın veri yapıları ve iş mantığını içerecek.
Views: Kullanıcı arayüzü şablonlarını içerecek.
wwwroot: Statik dosyalar (CSS, JavaScript, resimler vb.) için kullanılacak.
Program.cs Dosyasının Yapılandırılması
Program.cs dosyanızda aşağıdaki adımları izleyin:

MVC Servislerinin Eklenmesi

MVC özelliklerini etkinleştirmek için gerekli servisleri ekleyin. Bu, uygulamanızın MVC bileşenlerini (controller'lar ve view'lar) kullanabilmesini sağlar.

Statik Dosyaların Kullanımının Belirtilmesi

wwwroot klasöründeki statik dosyaların kullanılmasını sağlamak için yapılandırmayı tamamlayın. Bu, CSS, JavaScript ve resimlerin düzgün şekilde sunulmasını sağlar.

Routing Konfigürasyonu

Tarayıcıdan gelen isteklerin doğru şekilde yönlendirilmesini sağlamak amacıyla routing yapılandırmasını tamamlayın. Routing, URL'leri controller'lara ve aksiyonlara yönlendirir.

Varsayılan Routing

Varsayılan routing yapılandırmasını ekleyin. Bu, uygulamanızın ana sayfasının varsayılan olarak belirli bir controller ve aksiyona yönlendirilmesini sağlar.

-Özet-

Bu yapılandırmaları tamamladıktan sonra, projeniz MVC yapısına uygun olarak çalışmaya hazır olacaktır. Controllers klasöründe controller'larınızı, Models klasöründe model sınıflarınızı, Views klasöründe ise view'lerinizi oluşturabilirsiniz. wwwroot klasöründe ise CSS, JavaScript ve diğer statik dosyalarınızı barındırabilirsiniz.

Uygulamanızı başlattığınızda, varsayılan routing yapılandırması ile belirlediğiniz controller'ın ana aksiyonu ana sayfanız olarak görüntülenecektir.

