# SignalR Demo

## Proje Özeti

- Backend tarafında bir **BackgroundService (Hosted Service)** çalışır.
- Bu servis belirli aralıklarla **rastgele sayılar üretir**.
- Üretilen değerler **InMemory (Singleton Service)** içinde tutulur.
- Her veri güncellendiğinde **SignalR Hub** üzerinden tüm bağlı client’lara push edilir.
- Angular frontend, SignalR bağlantısı ile bu verileri **anlık olarak ekranda günceller**.

---

## Kullanılan Teknolojiler

### Backend
- .NET 6+ Web API
- SignalR
- BackgroundService (IHostedService)
- InMemory veri yönetimi
- CORS yapılandırması

### Frontend
- Angular
