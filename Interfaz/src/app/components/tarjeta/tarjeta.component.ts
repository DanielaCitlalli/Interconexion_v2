import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { CirrTa03Depeticion } from 'src/app/models/CirrTa03Depeticion.model';
import { Nrc_Nacimientos } from 'src/app/models/NrcNacimientos';
import { Nrc_Matrimonios } from 'src/app/models/Nrc_Matrimonios';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';

@Component({
  selector: 'app-tarjeta',
  templateUrl: './tarjeta.component.html',
  styleUrls: ['./tarjeta.component.css']
})
export class TarjetaComponent implements OnInit, OnChanges {

  registroEnviar: any;
  registroEnviarCambioSexo:  any;
  cadenasDisponibles?: Nrc_Nacimientos[];
  cambioSexoDisponible: boolean = false;
  datos: any;

  verSpinner: boolean = false;

  constructor(private tarjetaService: TarjetaServiceService) { }

  ngOnInit(): void {
    
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
    //Para cuando se ejecuta la busqueda por Crip
    else if(event.tarea === 'busquedaCrip'){
      this.cadenasDisponibles = event.registro;
      this.verSpinner = false;
      return;
    }


    //Para mandar registro afectado en procesos de borrar y subir actas
    this.registroEnviar = event.registro;

    //Para llenar segundo formulario(cambio de sexo) con el registro encontrado
    this.datos = event;

    //habilitarForm - Para mostrar formulario de cambio de sexo
    this.cambioSexoDisponible = event.habilitarForm;

    // Para enviar registro afectado despues de cambio de sexo en segundo formulario, 
    // se envia null porque no debe mostrar nada en tabla de resultados de matrimonio
    this.registroEnviarCambioSexo = null;

    
    this.cadenasDisponibles = undefined;

    //Desaparecer spinner
    this.verSpinner = false;
    
  }

  mostrarRegistroDevuletoCambioSexo(event: any){

    if(event === undefined){
      this.verSpinner = true;
      return;
    }
    else if(event === 'error'){
      this.verSpinner = false;
      return
    }

    //Para enviar registro afectado despues de cambio de sexo en segundo formulario
    this.registroEnviarCambioSexo = event;
    this.cambioSexoDisponible = false;

    this.verSpinner = false;
  }

}