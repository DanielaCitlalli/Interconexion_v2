import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { CirrTa03Depeticion } from 'src/app/models/CirrTa03Depeticion.model';

@Component({
  selector: 'app-tarjeta',
  templateUrl: './tarjeta.component.html',
  styleUrls: ['./tarjeta.component.css']
})
export class TarjetaComponent implements OnInit, OnChanges {

  registroEnviar: any;
  registroEnviarCambioSexo:  any;
  cambioSexoDisponible: boolean = false;
  datos: any;


  constructor() { }

  ngOnInit(): void {
    // console.log(this.cambioSexoDisponible);
    
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log(changes);
    console.log('estoy en ngonchanges tarjeta-component');
    
  }

  //Recibe el valor que se emita por Output en tarjeta-credito
  mostrarRegistroDevuleto(event: any){
    // if(event !== true){
    //   this.registroEnviar = event;
    //   console.log(this.registroEnviar , 'componente Padre');
    // }
    // else{
    //   //Si es igual true, habilita el segundo formulario
    //   this.cambioSexoDisponible = event;
    // }
   // console.log('prueba ' , event);
    
    this.registroEnviar = event.registro;

    this.datos = event;
    this.cambioSexoDisponible = event.habilitarForm;
    this.registroEnviarCambioSexo = null;
    // console.log(this.registroEnviar , this.cambioSexoDisponible);
    
  }

  mostrarRegistroDevuletoCambioSexo(event: any){
   // console.log(event);
    
    this.registroEnviarCambioSexo = event;
    this.cambioSexoDisponible = false;
  }

}