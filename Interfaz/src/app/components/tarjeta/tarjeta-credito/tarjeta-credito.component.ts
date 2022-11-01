import { Component, OnDestroy, OnInit, Output, EventEmitter } from '@angular/core';
import { resetFakeAsyncZone } from '@angular/core/testing';
import { FormGroup, FormBuilder, Validators, FormControl, NgSelectOption } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { Nrc_Nacimientos } from 'src/app/models/NrcNacimientos';
import { Nrc_Defunciones } from 'src/app/models/Nrc_Defunciones';
import { TarjetaCredito } from 'src/app/models/tarjetaCredito.model';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';
import { CirrTa01Napeticion } from '../../../models/CirrTa01Napeticion.model';
import { CirrTa03Depeticion } from '../../../models/CirrTa03Depeticion.model';
import { CirrTa09Mapeticion } from '../../../models/CirrTa09Mapeticion.model';
import { ListaTarjetaCreditoComponent } from '../lista-tarjeta-credito/lista-tarjeta-credito.component';


@Component({
  selector: 'app-tarjeta-credito',
  templateUrl: './tarjeta-credito.component.html',
  styleUrls: ['./tarjeta-credito.component.css']
})
export class TarjetaCreditoComponent implements OnInit, OnDestroy {


  @Output() registroDevuelto: EventEmitter<any> = new EventEmitter();
  

  form: FormGroup;

  globalForm: FormGroup;

  globalFormbuscar: FormGroup;

  suscription?: Subscription;

  tarjeta?: TarjetaCredito;
  idTarjeta?: number = 0;

  public opcion = '';


  constructor(private formBuilder: FormBuilder,
              private tarjetaService: TarjetaServiceService,
              private toastr: ToastrService) { 

              


    this.form = this.formBuilder.group({
      id: 0,
      titular: ['' , [Validators.required]],
      tarjetaCredito: ['' , [Validators.required , Validators.maxLength(16) , Validators.minLength(16)]],
      fechaExperiacion: ['' , [Validators.required , Validators.maxLength(5) , Validators.minLength(5)]],
      cvv: ['' , [Validators.required , Validators.maxLength(3) , Validators.minLength(3)]]
    });

    //form  global
    this.globalForm = this.formBuilder.group({
      proceso: ['' , [Validators.required]],
      cadena: ['' , [Validators.required , Validators.maxLength(20) , Validators.minLength(20) , Validators.pattern(this.tarjetaService.rxCadena)]]
    });

    this.globalFormbuscar = this.formBuilder.group({
      crip : ['',[Validators.required , Validators.maxLength(14),Validators.minLength(14), Validators.pattern(this.tarjetaService.rxCrip)]]
    });
    


  }   
    
                                                                                                                                    

  ngOnInit(): void {
    this.suscription = this.tarjetaService.obtenerTarjetasUpdate().subscribe(data => {
      // console.log(data);
      this.tarjeta = data;
      this.form.patchValue({
        titular: this.tarjeta.titular,
        tarjetaCredito: this.tarjeta.numeroTarjeta,
        fechaExperiacion: this.tarjeta.fechaExpiracion,
        cvv: this.tarjeta.cvv
      });
      this.idTarjeta = this.tarjeta.id;


      // this.globalForm.get('crip')?.valid
    });
  }

  ngOnDestroy(){
    this.suscription?.unsubscribe();   
  }

  
  guardar(){

    if(this.idTarjeta === 0){
      this.agregar();
    }
    else{
      this.editar();
    }
    
  }

   

  

  agregar(){
    const tarjeta: TarjetaCredito = {
      titular: this.form.get('titular')?.value,
      numeroTarjeta: this.form.get('tarjetaCredito')?.value,
      fechaExpiracion: this.form.get('fechaExperiacion')?.value,
      cvv: this.form.get('cvv')?.value
    }

    this.tarjetaService.guardarTarjeta(tarjeta).subscribe(data => {
      this.toastr.success('Registro Agregado' , 'La tarjeta fue agregada');
      this.tarjetaService.obtenerTarjetas();
      this.form.reset();
      
    });
  }

  editar(){
    const tarjeta: TarjetaCredito = {
      id: this.tarjeta?.id,
      titular: this.form.get('titular')?.value,
      numeroTarjeta: this.form.get('tarjetaCredito')?.value,
      fechaExpiracion: this.form.get('fechaExperiacion')?.value,
      cvv: this.form.get('cvv')?.value
    }

    this.tarjetaService.actualizarTarjeta(this.idTarjeta , tarjeta).subscribe(data => {
      this.toastr.info('Registro Actualizado' , 'La tarjeta fue actualizada');
      this.tarjetaService.obtenerTarjetas();
      this.form.reset();
      this.idTarjeta = 0;
    });
  }

  campoNoEsValido(campo: string){
    return this.globalForm.controls[campo].errors &&
            this.globalForm.controls[campo].touched
  }

 
   
  validar()
{

if( this.globalForm !== undefined){
  let infoEnviada = {
    habilitarForm: false
  }
  
  this.registroDevuelto.emit(infoEnviada)
  
}


 
 
}

refrescar(){
  this.globalForm.patchValue({
    proceso: '',
    cadena : ''
  })
 

}


ejecutarGlobal(){

  const procesoValue = this.globalForm.get('proceso')?.value;
  // console.log(this.globalForm.get('proceso')?.value);

  switch (procesoValue) {
    case "borrarDef":
      const form03: CirrTa03Depeticion = {
        ta03EOid: 0,
        ta03EPrioridad: 1,
        ta03EOperacionacto: 2,
        ta03CCadena: this.globalForm.get('cadena')?.value,
        ta03EEstatus: 0,
        ta03FEntrada: null,
        ta07EEstadodest: null,
        ta07EOiddestino: null,
        ta07ESolicitarimagen: null,
        ta03ESecuencia: null,
        ta03FAtencion: null,
        ta03ECuantos: 0

      }
      if(form03.ta03CCadena[0] !== '2'){
        this.toastr.error('Debe comenzar con 2' , 'Error');
        return;
      }

      this.registroDevuelto.emit(undefined);
      

      this.tarjetaService.postCirrTa03Depeticion(form03).subscribe(data => {

        if(data !== null && data !== undefined){
          this.toastr.success('Defuncion borrada con exito', "Defuncion borrada" , {
            closeButton: true,
            disableTimeOut: false,
          });
         this.refrescar();
          let infoEnviada = {
            registro: data,
            habilitarForm: false
          }
          this.registroDevuelto.emit(infoEnviada);
        }
        else{
          this.toastr.error('Error al ingresar dato', " Error  " , {
            closeButton: true,
            disableTimeOut: false,
          }
          );
        }
        
      });

      break;
    case "borrarMat":
      const form09: CirrTa09Mapeticion = {
        ta09EOid:0,
        ta09ESecuencia:null,
        ta09EPrioridad:1,
        ta09EOperacionacto: 2,
        ta09CCadena:this.globalForm.get('cadena')?.value,
        ta09FEntrada:null,
        ta09EEstatus:0,
        ta07EEstadodest: null,
        ta07EOiddestino: null,
        ta07ESolicitarimagen: null,
        ta09FAtencion: null,
        ta09ECuantos: 0

      }
      if(form09.ta09CCadena[0] !== '3'){
        this.toastr.error('Debe comenzar con 3' , 'Error');
        return;
      }

      this.registroDevuelto.emit(undefined);

      this.tarjetaService.postCirrTa09Mapeticion(form09).subscribe(data => {

        if(data !== null && data !== undefined){
          this.toastr.success('Matrimonio borrado con exito', " Borrar matrimonio con éxito" , {
            closeButton: true,
            disableTimeOut: false,
          });
          this.refrescar();
          let infoEnviada = {
            registro: data,
            habilitarForm: false
            
          }
          this.registroDevuelto.emit(infoEnviada);
        }
        else{
          this.toastr.error('Error al ingresar dato', " Error al ingresar Matrimonio" , {
            closeButton: true,
            disableTimeOut: false,
          }
          );  
        }

      });

      break;
    case "borrarNac":
      const form: CirrTa01Napeticion = {
        ta01EOid: 0,
        ta01ESecuencia: null,
        ta01EPrioridad: 1,
        ta01EOperacionacto:2,
        ta01CCadena: this.globalForm.get('cadena')?.value,
        ta01FEntrada:null,
        ta01EEstatus: 0,
        ta07EEstadodest: null,
        ta07EOiddestino: null,
        ta07ESolicitarimagen: null,
        ta01FAtencion: null,
        ta01ECuantos: 0

      }
      if(form.ta01CCadena[0] !== '1'){
        this.toastr.error('Debe comenzar con 1' , 'Error');
        return;
      }

      this.registroDevuelto.emit(undefined);

      this.tarjetaService.postCirrTa01Napeticion(form).subscribe(data => {

        if(data !== null && data !== undefined){
          this.toastr.success('Nacimiento borrado con exito', " Nacimiento borrado" , {
            closeButton: true,
            disableTimeOut: false,
          }
          );
          this.refrescar();
          let infoEnviada = {
            registro: data,
            habilitarForm: false
          }
          this.registroDevuelto.emit(infoEnviada);
         
        }
        else{
          this.toastr.error('Error al ingresar dato', " Error al ingresar Nacimiento" , {
            closeButton: true,
            disableTimeOut: false,
          }
          );  
        }

      });

      break;
    case "forzarSubirNac":
      const form1: CirrTa01Napeticion = {
        ta01EOid: 0,
        ta01ESecuencia: null,
        ta01EPrioridad: 1,
        ta01EOperacionacto: 1,
        ta01CCadena: this.globalForm.get('cadena')?.value,
        ta01FEntrada: null,
        ta01EEstatus: 0,
        ta07EEstadodest: null,
        ta07EOiddestino: null,
        ta07ESolicitarimagen: null,
        ta01FAtencion: null,
        ta01ECuantos: 0

      }

      // for(let i = 0; i < form1.ta01CCadena.length; i++){
      //   if(form1.ta01CCadena[i]){

      //   }
      // }

      if(form1.ta01CCadena[0] !== '1'){
        this.toastr.error('Debe comenzar con 1' , 'Error');
        return;
      }

      this.registroDevuelto.emit(undefined);

      this.tarjetaService.postCirrTa01Napeticion1(form1).subscribe(data => {

        if(data !== null && data !== undefined){
          this.toastr.success('Nacimiento subido con exito', " Nacimiento Éxitoso" , {
            closeButton: true,
            disableTimeOut: false,
          }
          );
          this.refrescar();
          let infoEnviada = {
            registro: data,
            habilitarForm: false
          }
          this.registroDevuelto.emit(infoEnviada);
        }
        else{
          this.toastr.error('Error al ingresar dato', " Error al ingresar Nacimiento" , {
            closeButton: true,
            disableTimeOut: false,
          }
          );  
        }

      });

      break;
    case "forzarSubirMat":
      const form09f: CirrTa09Mapeticion = {
        ta09EOid: 0,
        ta09ESecuencia: null,
        ta09EPrioridad: 1,
        ta09EOperacionacto: 1,
        ta09CCadena: this.globalForm.get('cadena')?.value,
        ta09FEntrada: null,
        ta09EEstatus: 0,
        ta07EEstadodest: null,
        ta07EOiddestino: null,
        ta07ESolicitarimagen: null,
        ta09FAtencion: null,
        ta09ECuantos: 0

      }
      if(form09f.ta09CCadena[0] !== '3'){
        this.toastr.error('Debe comenzar con 3' , 'Error');
        return;
      }
      this.registroDevuelto.emit(undefined);

      this.tarjetaService.postCirrTa09MapeticionF(form09f).subscribe(data => {
        
        if(data !== null && data !== undefined){
          this.toastr.success('Matrimonio subido con exito', " Matrimonio subido con Éxito" , {
            closeButton: true,
            disableTimeOut: false,
          }
          );
          this.refrescar();
          let infoEnviada = {
            registro: data,
            habilitarForm: false
          }
          this.registroDevuelto.emit(infoEnviada);
        }
        else{
          this.toastr.error('Error al ingresar dato', " Error al ingresar Matrimonio" , {
            closeButton: true,
            disableTimeOut: false,
          }
          );  
        }

      });
      break;
    case "forzarSubirDef":
      const form03F: CirrTa03Depeticion = {
        ta03EOid: 0,
        ta03EPrioridad: 1,
        ta03EOperacionacto: 1,
        ta03CCadena: this.globalForm.get('cadena')?.value,
        ta03EEstatus: 0,
        ta03FEntrada: null,
        ta07EEstadodest: null,
        ta07EOiddestino: null,
        ta07ESolicitarimagen: null,
        ta03ESecuencia: null,
        ta03FAtencion: null,
        ta03ECuantos: 0
        
      }
      if(form03F.ta03CCadena[0] !== '2'){
        this.toastr.error('Debe comenzar con 2' , 'Error');
        return;
      }
      
      this.registroDevuelto.emit(undefined);

      this.tarjetaService.postCirrTa03Depeticion2(form03F).subscribe(data => {

        if(data !== null && data !== undefined){
          this.toastr.success('Defuncion subido con exito', " Defunción subida con éxito" , {
            closeButton: true,
            disableTimeOut: false,
          }
          );
          this.refrescar();
          let infoEnviada = {
            registro: data,
            habilitarForm: false
          }
          this.registroDevuelto.emit(infoEnviada);
        }
        else{
          this.toastr.error('Error al ingresar dato', " Error al ingrsar defunción" , {
            closeButton: true,
            disableTimeOut: false,
          }
          );  
        }


      });


      break;
    case "cambioSexo":
      
      this.registroDevuelto.emit(undefined);

      this.tarjetaService.getNrcmatrimoniosId(this.globalForm.get('cadena')?.value).subscribe(data => {
        // console.log(data);
        let infoEnviada = {
          registro: data,
          habilitarForm: true
          
        }
        this.registroDevuelto.emit(infoEnviada);
        this.toastr.success('Registro encontrado ', "Operación exitosa" , {
          closeButton: true,
          disableTimeOut: false,
        })
        
      },
      error => {
        this.toastr.error(error.error , 'Ocurrio un error',{
          closeButton: true,
          disableTimeOut: false,

        });
        this.registroDevuelto.emit('error');
      });
      console.log('llegue a buscar dublicados ');

     
      
      break;

    default:
      break;
  }
  
}
ejecutarBusqueda(){
  // const buscarValue = this.globalFormbuscar.get('proceso')?.value;



  //     const formNa: Nrc_Nacimientos = {
  //       numeroacta: 0,
  //       anioregistro: 0,
  //       entidadregistro: 0,
  //       municipioregistro: 0,
  //       oficilia: 0,
  //       actabis: '',
  //       cadena: '',
  //       imnombreoriginalimagen: null,
  //       imarchivo: null,
  //       otnotasmarginales: null,
  //       otcrip: null,
  //       Otvivoomuerto: null,
  //       peprimerapellido: null,
  //       pesegundoapellido: null,
  //       penombres: null,
  //       peedad: null,
  //       pesexo: null,
  //       pefechanacimiento: null,
  //       pefechanacimientoinc: null,
  //       pelocalidadnacimiento: null,
  //       pecurp: null,
  //       paprimerapellido: null,
  //       pasegundoapellido: null,
  //       panombres: null,
  //       paedad: null,
  //       pasexo: null,
  //       pafechanacimiento: null,
  //       pafechanacimientoinc: null,
  //       palocalidadnacimiento: null,
  //       pacurp: null,
  //       maprimerapellido: null,
  //       masegundoapellido: null,
  //       manombres: null,
  //       maedad: null,
  //       masexo: null,
  //       mafechanacimiento: null,
  //       mafechanacimientoinc: null,
  //       malocalidadnacimiento: null,
  //       macurp: null,
  //       cnfechaactualizacioninc: null,
  //       otcertificadona: null
  //     }
  //     console.log(this.globalFormbuscar.get('proceso')?.value);
      this.registroDevuelto.emit(undefined);

      this.tarjetaService.getDuplicados(this.globalFormbuscar.get('crip')?.value).subscribe(data => {
         console.log(data);
        let infoEnviada = {
          registro: data,
          habilitarForm: false
          
        }
        this.registroDevuelto.emit(infoEnviada);
        // this.toastr.success('Registro encontrado ', "Operación exitosa" , {
        //   closeButton: true,
        //   disableTimeOut: false,
        // })
        
      },
      error => {
        this.toastr.error(error.error , 'Ocurrio un error',{
          closeButton: true,
          disableTimeOut: false,

        });
        this.registroDevuelto.emit('error');
      });
       console.log('llegue a dublicados ');

      // this.globalFormbuscar.reset();
      
    
      

}

}
