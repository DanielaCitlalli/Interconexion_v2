import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { CirrTa03Depeticion } from 'src/app/models/CirrTa03Depeticion.model';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';

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

  verSpinner: boolean = false;

  constructor(private tarjetaService: TarjetaServiceService) { }

  ngOnInit(): void {
    // console.log(this.cambioSexoDisponible);
    this.tarjetaService.getDuplicados(11002011300358).subscribe(data => {
      console.log(data);
      
    });
    
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log(changes);
    console.log('estoy en ngonchanges tarjeta-component');
    
  }

  //Recibe el valor que se emita por Output en tarjeta-credito
  mostrarRegistroDevuleto(event: any){
    
    //para ver el spinner 
    if(event === undefined){
      this.verSpinner = true;
      return;
    }
    //Para desaparecer spinner cuando ocurre un error en la peticion http
    else if(event === 'error'){
      this.verSpinner = false;
      return;
    }



    this.registroEnviar = event.registro;

    this.datos = event;
    this.cambioSexoDisponible = event.habilitarForm;
    this.registroEnviarCambioSexo = null;


    this.verSpinner = false;
    // console.log(this.registroEnviar , this.cambioSexoDisponible);
    
  }

  mostrarRegistroDevuletoCambioSexo(event: any){
   // console.log(event);
    

    if(event === undefined){
      this.verSpinner = true;
      return;
    }
    else if(event === 'error'){
      this.verSpinner = false;
      return
    }

    this.registroEnviarCambioSexo = event;
    this.cambioSexoDisponible = false;

    this.verSpinner = false;
  }

}