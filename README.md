# Ticimax UI Test

Bu proje istenilen senaryonun yapıldığı  test otomasyon web ui projesidir.   <br /><br />

## Proje Özellikleri
* Katmanlı mimari olarak tasarlanmıştır.
* Projeye mobil test caseleri katmanı eklenerek otomatize hale getirilebilinir
* C# dilinde yazılmıştır.
* C# en güncel frameworkü asp.net core 5.0 ile yazılmıştır.
* Nunit mimarisi üzerine inşa edilmiştir.
* Url: https://test3.ticimax.dev/
* Host için Microsoft.Net.Test.Sdk kütüphanesi kullanılmıştır.
* Nunit3TestAdapter yapısı ile testlerin çalışması sağlanmaktadır.
* Paralel test yapısı kurularak bir den fazla tarayıcı ve testlerin aynı anda yürütülmesi yapılabilinir.
* Clouda taşınarak sürekli test yapılabilinir.
* Selenium Web driver ve ChromeWebDriver kütüphaneleri kullanılmıştır
* Assertion için exception ve actual result eklenebilir yapıdadır
* Geliştirilmiş Class yapısıyla kurulmuştur. 
* İlerleyen sürümlerde, Güvenlik, Seo, APi, Yük ve Strees testi gibi katmanlarla proje geliştirilecektir.
* Gerektiği takdirde Docker ve Container mimarileri kullanılarak birbirimden bağımsız işletim sistemleri ve tarayıcıları üzerinde CrossBrowser Testler yapılacaktır
* Gerektiği takdirde Veritabanı Mimarisi eklenebilir.





## Task İsterleri
1. Siteye Gidilir
2. Abide sayfasında ürün seçilir
3. Renk ve beden seçilerek ürün sepete eklenir.
4. Sepetim sayfasında siparişi tamamla denir.
5. Login olunur.(Kayıtlı kullanıcı yoksa üye olunur)
6. Adres yoksa adres eklenir varsa siparişi tamamla denilir.
7. Kapıda ödeme seçilir ve siparişi tamamla denilir
8. Ön bilgilendirme formu onaylanır
9. Sipariş tamamlanır ve Sipariş numarasının geldiği görülür.
