import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  eventos: any = [
  /*
    {
    EventoId: 1,
    Tema: 'Angular',
    Local: 'Belo Horizonte' 
  },  
  {
    EventoId: 2,
    Tema: '.NET Core',
    Local: 'São Paulo' 
  },
  {
    EventoId: 3,
    Tema: 'Angular e .NET Core',
    Local: 'Rio de Janeiro' 
  }
  */
];

  constructor( private http: HttpClient) { }

  ngOnInit() {

    this.getEventos();  
  }

  getEventos(){
    this.eventos = this.http.get('http://localhost:5000/api/weatherforecast').subscribe(
    Response => {
                  this.eventos = Response;
                }, 
      error => {
                  console.log(error);
                });
  }
}
