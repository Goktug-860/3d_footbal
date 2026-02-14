3D Unity İki Kişilik Futbol Oyunu

Bu proje, Unity ile geliştirilmiş yerel iki kişilik 3D futbol oyunudur.
Aynı bilgisayarda iki oyuncu aynı anda oynayabilir.

PROJE ÖZELLİKLERİ

1)Tamamen yerel 2 oyuncu desteği (tek klavye).

2)Tek kamera.

3)Gerçekçi fizik tabanlı top hareketi.

4)Çim saha.

ADIM ADIM OLUŞTURULMASI

Unity Hub → Yeni 3D (URP) proje oluşturun (Unity 2022.3+ önerilir)
Input System paketini yükleyin (Package Manager → Input System)
Saha oluşturun (Plane + kale direkleri + çim texture)
Top → Sphere + Rigidbody + Sphere Collider + Physic Material (bounciness 0.7)
Player1 ve Player2 oluşturun (küp şeklinde + farklı renkler)
Player1'e player1 script'ini,Player2'ye player2 script'ini her iki oyuncuya bağlayın.


NASIL ÇALIŞTIRILACAK
Editor'de:

Play tuşuna basın,

Player 1: WASD 

Player 2: Ok Tuşları 


İÇERİSİNDE NELER VAR

Assets/

    kodlar/
      kale.cs
      kale.cs.meta
      player1.cs
      player1.cs.meta
      player2.cs
      player2.cs.meta
      top.cs
      top.cs.meta
    renkler/
      kale
      kale.mat.meta
      player1
      player1.mat.meta
      player2
      player2.mat.meta
      top
      top.mat.meta
    scenes/
      SampleScene.unity
      SampleScene.unity.meta
    futbol_0.1.unity
    futbol_0.1.unity.meta
    kodlar.meta
    renkler.meta
    resimler.meta
    Scenes.meta

 |   
SÖZLÜK KISMI

Physic Material: sürtünme ayarları

Rigidbody: Fizik motoru bileşeni

Mesh collider:Düz zemin collideri

Box collider:Duvarların içinden geçilmez olması(Dikdörtgen veya kare için geçerli)

Sphere collider: içinden geçmemeyi sağlar(yuvarlak nesneler içn geçerli)

Scenes:Sahnelerin yeri



İYİ YÖNLERİ

Gerçekçi fizik ve top davranışı
Kolay ayırt edilebilir iki oyuncu (farklı renkler)
Modüler yapı (kolayca 4 oyuncuya genişletilebilir)

GELİŞTİRİLMESİ GEREKEN YÖNLER

AI rakip modu (tek oyunculu için)
Online multiplayer (Photon / Netcode)
Daha kaliteli karakter modelleri ve animasyonlar
Ses efektleri (şut, gol, tezahürat)
Menü sistemi (Başla, Mod Seç, Çıkış)
Yeniden başlama (restart) özelliği
Performans optimizasyonu (LOD, occlusion culling)
Daha iyi klavye yolları
İki oyuncu için ayrı kameralar olması
Kamera hareketi


RESİMLER

<img width="736" height="727" alt="saha resm" src="https://github.com/user-attachments/assets/2cd4fca8-963a-4eba-8e7c-31658a489c1a" />

<img width="1638" height="837" alt="saha resm 01" src="https://github.com/user-attachments/assets/b0493a23-906a-4e0b-b7a5-d22f14caef29" />


BENİM GÖRÜŞ VE SÖZLERİM

Bunun diğer sürümlerini başka kullanıcılardan yapmalarını istiyorum.
Onlar ise benimle iletişime geçip lütfen o sürümleri gönderin bu sayede başkalarının da yaptıklarını karıp ortaya yeni bir oyun yapmak çok isterim.
Başarılar😊

Göktuğ Arı
