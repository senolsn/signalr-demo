import { Component, OnInit } from '@angular/core';
import { HubConnection } from '@microsoft/signalr';
import { HubConnectionBuilder } from '@microsoft/signalr';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit {
  title = 'signalr-demo-client';

  public value: number = 0;
  private hubConnection!: HubConnection;

  ngOnInit(): void {
    this.hubConnection = new HubConnectionBuilder()
      .withUrl('http://localhost:29564/numberHub')
      .withAutomaticReconnect()
      .build();

    this.hubConnection.start();

    this.hubConnection.on('receiveNumber', (data: number) => {
      this.value = data;
    })
  }
}
