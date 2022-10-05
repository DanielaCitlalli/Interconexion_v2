import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { CirrTa03Depeticion } from 'src/app/models/CirrTa03Depeticion.model';

@Component({
  selector: 'app-tarjeta',
  templateUrl: './tarjeta.component.html',
  styleUrls: ['./tarjeta.component.css']
})
export class TarjetaComponent implements OnInit, OnChanges {

  registroEnviar: any;
  cambioSexoDisponible: boolean = false;


  constructor() { }

  ngOnInit(): void {
    console.log(this.cambioSexoDisponible);
    
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log(changes);
  }

  mostrarRegistroDevuleto(event: any){
    this.registroEnviar = event;
    console.log(this.registroEnviar , 'componente Padre');
    //Hoolaaa , probando........
    //lksajdshfdhsdkjfhdsjfh
    //daaaaaaaaaaaaaaaaaani
  }


}