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
  //cambio nacionalidad
  nacionalidadDisponible:boolean=false;
  //agregar/editar nacionalidad
  paisesDisponibles: boolean = false;
  editarPais: boolean = false;
  editarPaisMat: boolean = false;
   BuscarPais: number = 1;

  registronacimientos:any;

  verSpinner: boolean = false;

  constructor(private tarjetaService: TarjetaServiceService) { }

  ngOnInit(): void {
    
  }

  ngOnChanges(changes: SimpleChanges): void {
    
    
  }

  //Recibe el valor que se emita por Output en tarjeta-credito
  mostrarRegistroDevuleto(event: any){
    
    //para ver el spinner 
    if(event === undefined){
      this.verSpinner = true;
      this.cadenasDisponibles = undefined;
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
    //Para habilitar formulario de cambio de nacionalidad
    else if(event.habilitarFormNacionalidad === true){
      this.nacionalidadDisponible = true;
      this.registronacimientos = event.registro;
      this.verSpinner = false;
      
      return;

    }
    //Para habilitar formulario de editar/agregar país
    else if(event.habilitarFormPais === true){
      this.paisesDisponibles = true;
      this.editarPais = event.editarPais;
       this.BuscarPais = event.BuscarPais;
      this.verSpinner = false;

      return;
    }

 

  


    //Para mandar registro afectado en procesos de borrar y subir actas
    this.registroEnviar = event.registro;

    //Para llenar segundo formulario(cambio de sexo) con el registro encontrado
    this.datos = event;

    this.registronacimientos = event;

    //habilitarForm - Para mostrar formulario de cambio de sexo
    this.cambioSexoDisponible = event.habilitarForm;

    //Decide que formulario usar del segundo formulario (cambio de sexo o de nacionalidad)
    this.editarPaisMat = event.editarNacionalidad;
   

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

  mostrarRegistroDevuletoNacionalidad(event: any){

    if(event === undefined){
      this.verSpinner = false;
      return;
    }
    else if(event === 'error'){
      this.verSpinner = false;
      return
      
    }

    //Para enviar registro afectado despues de cambio de sexo en segundo formulario
    this.registronacimientos = event;
    this.nacionalidadDisponible = false;

    this.verSpinner = false;
  }

  mostrarRegistroDevuletoPais(event: any){

    if(event === undefined){
      this.verSpinner = false;
      return;
    }
    else if(event === 'error'){
      this.verSpinner = false;
      return
      
    }

    //Para enviar registro afectado despues de cambio de sexo en segundo formulario
    //this.registronacimientos = event;
    this.paisesDisponibles = false;

    this.verSpinner = false;
  }

}