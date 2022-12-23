import { Component, OnDestroy, OnInit, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl, NgSelectOption } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { TarjetaCredito } from 'src/app/models/tarjetaCredito.model';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';
import { CirrTa01Napeticion } from '../../../models/CirrTa01Napeticion.model';
import { CirrTa03Depeticion } from '../../../models/CirrTa03Depeticion.model';
import { CirrTa09Mapeticion } from '../../../models/CirrTa09Mapeticion.model';
import { Nrc_Nacimientos} from'../../../models/NrcNacimientos';

import Swal from "sweetalert2";





@Component({
  selector: 'app-tarjeta-credito',
  templateUrl: './tarjeta-credito.component.html',
  styleUrls: ['./tarjeta-credito.component.css']
})
export class TarjetaCreditoComponent implements OnInit, OnDestroy {


  @Output() registroDevuelto: EventEmitter<any> = new EventEmitter();
  

 

  globalForm: FormGroup;

  globalFormbuscar: FormGroup;

  suscription?: Subscription;

 
  public opcion = '';


  constructor(private formBuilder: FormBuilder,
              private tarjetaService: TarjetaServiceService,
              private toastr: ToastrService) { 

              

    //form  global
    this.globalForm = this.formBuilder.group({
      proceso: ['' , [Validators.required]],
      cadena: ['' , [Validators.required , Validators.maxLength(20) , Validators.minLength(20) , Validators.pattern(this.tarjetaService.rxCadena)]]
    });

    this.globalFormbuscar = this.formBuilder.group({
      crip : ['',[Validators.required , Validators.maxLength(14),Validators.minLength(14), Validators.pattern(this.tarjetaService.rxCrip)]],
      checkbox : [false]
    });
    


  }   
    
                                                                                                                                    

  ngOnInit(): void {
   
  }

  ngOnDestroy(){
    this.suscription?.unsubscribe();   
  }



  campoNoEsValido(campo: string){
    if(campo === 'crip'){
      return this.globalFormbuscar.controls[campo].errors &&
      this.globalFormbuscar.controls[campo].touched
    }
    return this.globalForm.controls[campo].errors &&
            this.globalForm.controls[campo].touched
  }

 
   

  validar(){

    if(this.globalForm.controls['proceso'].value === 'BuscarPais'){
      this.Buscarpais(1);
    }
    if(this.globalForm.controls['proceso'].value === 'agregarPais'){
      this.irFormPais(false);
    }
    else if(this.globalForm.controls['proceso'].value === 'editarPais'){
      this.irFormPais(true);
    }

    if( this.globalForm !== undefined){
      let infoEnviada = {
        habilitarForm: false
      }
      
      this.registroDevuelto.emit(infoEnviada)
      this.globalForm.patchValue({
        cadena : ''
      })
      
      this.globalFormbuscar.patchValue({
        crip : '',
        checkbox: false
      })
    }
  }

refrescar(){
  this.globalForm.patchValue({
    proceso: '',
    cadena : ''
  })
}

limpiar(){
  this.globalFormbuscar.patchValue({
   crip: '',
   checkbox: false
  })
}

irFormPais(editar: boolean){
 
  
  this.registroDevuelto.emit(undefined);

  let infoEnviada = {
    registro: 'data',
    habilitarForm: false,
    habilitarFormPais:true,
    editarPais: editar
    
  }
 
  this.registroDevuelto.emit(infoEnviada);
}

Buscarpais(buscar : number){
 
  
  this.registroDevuelto.emit(undefined);

  let infoEnviada = {
    registro: 'data',
    habilitarForm: false,
    habilitarFormPais:true,
    BuscarPais: buscar
    
  }
  
  this.registroDevuelto.emit(infoEnviada);
}


ejecutarGlobal(){

  const procesoValue = this.globalForm.get('proceso')?.value;

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
        this.toastr.error('La cadena debe comenzar con 2' , 'Opeación Fallida');
        return;
      }

      Swal.fire({
        title: '¿Estas seguro de continuar?',
        text: "No podrás revertirlo",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Continuar',
        cancelButtonText: 'Cancelar'
      }).then((result) => {
        if (result.isConfirmed) {
          this.registroDevuelto.emit(undefined);
      

          this.tarjetaService.postCirrTa03Depeticion(form03).subscribe(data => {
    
            if(data !== null && data !== undefined){
              this.toastr.success('Se borro Defunción', "Operación Exitosa" , {
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
              this.toastr.error('Ocurrió un error al ingresar dato', " Opeación Fallida " , {
                closeButton: true,
                disableTimeOut: false,
              }
              );
            }
            
          });
        }
      })



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
        this.toastr.error('La cadena debe comenzar con 3' , 'Opeación Fallida');
        return;
      }

      Swal.fire({
        title: '¿Estas seguro de continuar?',
        text: "No podrás revertirlo",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Continuar',
        cancelButtonText: 'Cancelar'
      }).then((result) => {
        if (result.isConfirmed) {
          this.registroDevuelto.emit(undefined);
      

          this.tarjetaService.postCirrTa09Mapeticion(form09).subscribe(data => {
    
            if(data !== null && data !== undefined){
              this.toastr.success('Se borro Matrimonio', "Operación Exitosa" , {
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
              this.toastr.error('Ocurrió un error al ingresar dato', " Opeación Fallida " , {
                closeButton: true,
                disableTimeOut: false,
              }
              );
            }
            
          });
        }
      })

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
        this.toastr.error('La cadena debe comenzar con 1' , 'Operación fallida');
        return;
      }

      Swal.fire({
        title: '¿Estas seguro de continuar?',
        text: "No podrás revertirlo",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Continuar',
        cancelButtonText: 'Cancelar'
      }).then((result) => {
        if (result.isConfirmed) {
          this.registroDevuelto.emit(undefined);
      

          this.tarjetaService.postCirrTa01Napeticion(form).subscribe(data => {
    
            if(data !== null && data !== undefined){
              this.toastr.success('Se borro Nacimiento', "Operación Exitosa" , {
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
              this.toastr.error('Ocurrió un error al ingresar dato', " Operación fallida  " , {
                closeButton: true,
                disableTimeOut: false,
              }
              );
            }
            
          });
        }
      })
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

    

      if(form1.ta01CCadena[0] !== '1'){
        this.toastr.error('La cadena debe comenzar con 1' , 'Operación fallida');
        return;
      }

      Swal.fire({
        title: '¿Estas seguro de continuar?',
        text: "No podrás revertirlo",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Continuar',
        cancelButtonText: 'Cancelar'
      }).then((result) => {
        if (result.isConfirmed) {
          this.registroDevuelto.emit(undefined);
      

          this.tarjetaService.postCirrTa01Napeticion1(form1).subscribe(data =>
            {
    
            if(data !== null && data !== undefined){
              this.toastr.success('Se ingreso Nacimiento', "Operación Exitosa" , {
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
              this.toastr.error('Ocurrió un error al ingresar dato', " Opeación Fallida  " , {
                closeButton: true,
                disableTimeOut: false,
              }
              );
            }
            
          });
        }
      })
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
        this.toastr.error('La cadena debe comenzar con 3' , 'Opeación Fallida');
        return;
      }
      Swal.fire({
        title: '¿Estas seguro de continuar?',
        text: "No podrás revertirlo",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Continuar',
        cancelButtonText: 'Cancelar'
      }).then((result) => {
        if (result.isConfirmed) {
          this.registroDevuelto.emit(undefined);
      

          this.tarjetaService.postCirrTa09MapeticionF(form09f).subscribe(data =>

            {
    
            if(data !== null && data !== undefined){
              this.toastr.success('Se ingreso Matrimonio ', "Operación Exitosa" , {
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
              this.toastr.error('Ocurrió un error al ingresar dato', " Opeación Fallida  " , {
                closeButton: true,
                disableTimeOut: false,
              }
              );
            }
            
          });
        }
      })
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
        this.toastr.error('La cadena debe comenzar con 2' , 'Opeación Fallida');
        return;
      }
      
      Swal.fire({
        title: '¿Estas seguro de continuar?',
        text: "No podrás revertirlo",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Continuar',
        cancelButtonText: 'Cancelar'
      }).then((result) => {
        if (result.isConfirmed) {
          this.registroDevuelto.emit(undefined);
      

          this.tarjetaService.postCirrTa03Depeticion2(form03F).subscribe(data =>
            {
    
            if(data !== null && data !== undefined){
              this.toastr.success('Se ingreso Defunción ', "Operación Exitosa" , {
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
              this.toastr.error('Ocurrió un error al ingresar dato', "Opeación Fallida " , {
                closeButton: true,
                disableTimeOut: false,
              }
              );
            }
            
          });
        }
      })
      break;
    case "cambioSexo":
      
      this.registroDevuelto.emit(undefined);

      this.tarjetaService.getNrcmatrimoniosId(this.globalForm.get('cadena')?.value).subscribe(data => {
        
        let infoEnviada = {
          registro: data,
          habilitarForm: true
          
        }
        this.registroDevuelto.emit(infoEnviada);
        this.toastr.success('Se encontro registro ', "Operación Exitosa" , {
          closeButton: true,
          disableTimeOut: false,
        })
        
      },
      error => {
        this.toastr.error(error.error , 'Opeación Fallida',{
          closeButton: true,
          disableTimeOut: false,

        });
        this.registroDevuelto.emit('error');
      });
      

     
      
      break;
    case "cambiarnacionalidad":

      this.registroDevuelto.emit(undefined);

      this.tarjetaService.getNrcNacimientos(this.globalForm.get('cadena')?.value).subscribe((data:Nrc_Nacimientos) => {
      
        let infoEnviada = {
          registro: data,
          habilitarForm: false,
          habilitarFormNacionalidad:true
          
        }
      
        this.registroDevuelto.emit(infoEnviada);
      this.toastr.success('Se encontro registro ', "Operación Exitosa" , {
        closeButton: true,
        disableTimeOut: false,
      })
      
    },
    error => {
      this.toastr.error(error.error , 'Opeación Fallida',{
        closeButton: true,
        disableTimeOut: false,

      });
      this.registroDevuelto.emit('error');
    });
    
    break;

    case "BuscarPais":

    this.registroDevuelto.emit(undefined);

    this.tarjetaService.getNrcNacimientos(this.globalForm.get('cadena')?.value).subscribe((data:Nrc_Nacimientos) => {
    
      let infoEnviada = {
        registro: data,
        habilitarForm: false,
        habilitarFormNacionalidad:true
        
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
  
  break;



    case "agregarPais":

      this.registroDevuelto.emit(undefined);

      let infoEnviada = {
        registro: 'data',
        habilitarForm: false,
        habilitarFormPais:true
        
      }
   
      this.registroDevuelto.emit(infoEnviada);

    
    break;

    case "BuscarPais":

    this.registroDevuelto.emit(undefined);

    let inforEnviada = {
      registro: 'data',
      habilitarForm: false,
      habilitarFormPais:true
      
    }
    
    this.registroDevuelto.emit(inforEnviada);


  
  break;

    default:
      break;

       

  }
}
ejecutarBusqueda(){

  this.registroDevuelto.emit(undefined);

  const procesodebusqueda = this.globalForm.get('proceso')?.value;
  switch(procesodebusqueda){
    // Busqueda de dublicaados de Nacimentos
    case "borrarNac":
      
      this.tarjetaService.getDuplicadosNac(this.globalFormbuscar.get('crip')?.value).subscribe(data => {
        
        let infoEnviada = {
          registro: data,
          habilitarForm: false,
          tarea: 'busquedaCrip'
    }
    this.registroDevuelto.emit(infoEnviada);
    this.limpiar();
   
  },
  error => {
    this.toastr.error(error.error , 'Opeación Fallida',{
      closeButton: true,
      disableTimeOut: false,

        });
        this.registroDevuelto.emit('error');
      });
      

      // this.globalFormbuscar.reset();
  break;
    // Busqueda de dublicaados de forzar subir acta nacimientos
    case "forzarSubirNac":
      
      this.tarjetaService.getDuplicadosNac(this.globalFormbuscar.get('crip')?.value).subscribe(data => {
        
        let infoEnviada = {
          registro: data,
          habilitarForm: false,
          tarea: 'busquedaCrip'
          
        }
        this.registroDevuelto.emit(infoEnviada);
        this.limpiar();
        // this.toastr.success('Registro encontrado ', "Operación exitosa" , {
        //   closeButton: true,
        //   disableTimeOut: false,
        // })
        

    },
    error => {
      this.toastr.error(error.error , 'Opeación Fallida',{
        closeButton: true,
        disableTimeOut: false,

        });
        this.registroDevuelto.emit('error');
      });
      

      // this.globalFormbuscar.reset();
    break;
    // Busqueda de dublicaados de cambio de nacionalidad
    case "cambiarnacionalidad":
  
      this.tarjetaService.getDuplicadosNac(this.globalFormbuscar.get('crip')?.value).subscribe(data => {
        
        let infoEnviada = {
          registro: data,
          habilitarForm: false,
          tarea: 'busquedaCrip'
          
        }
        this.registroDevuelto.emit(infoEnviada);
        this.limpiar();
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
    

    // this.globalFormbuscar.reset();
    break;
    // Busqueda de dublicaados de Matrimoios 
    case "borrarMat":
    
      this.tarjetaService.getDuplicadosMat(this.globalFormbuscar.get('crip')?.value).subscribe(data => {
        
        let infoEnviada = {
          registro: data,
          habilitarForm: false,
          tarea: 'busquedaCrip'
          
        }
        this.registroDevuelto.emit(infoEnviada);
        this.limpiar();
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
      

      // this.globalFormbuscar.reset();
    break;
    // Busqueda de dublicaados de forzar subir acta matrimonios 
    case "forzarSubirMat":
      
      this.tarjetaService.getDuplicadosMat(this.globalFormbuscar.get('crip')?.value).subscribe(data => {
        
        let infoEnviada = {
          registro: data,
          habilitarForm: false,
          tarea: 'busquedaCrip'
          
        }
        this.registroDevuelto.emit(infoEnviada);
        this.limpiar();
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
      

      // this.globalFormbuscar.reset();
    break;
    // Busqueda de dublicaados de cambio de sexo 
    case "cambioSexo":
  
      this.tarjetaService.getDuplicadosMat(this.globalFormbuscar.get('crip')?.value).subscribe(data => {
        
        let infoEnviada = {
          registro: data,
          habilitarForm: false,
          tarea: 'busquedaCrip'
          
        }
        this.registroDevuelto.emit(infoEnviada);
        this.limpiar();
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
      

      // this.globalFormbuscar.reset();
    break;
    // Busqueda de dublicaados de Defunciones 
    case "borrarDef":
    
      this.tarjetaService.getDuplicadosDef(this.globalFormbuscar.get('crip')?.value).subscribe(data => {
        
        let infoEnviada = {
          registro: data,
          habilitarForm: false,
          tarea: 'busquedaCrip'
          
        }
        this.registroDevuelto.emit(infoEnviada);
        this.limpiar();
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
      

      // this.globalFormbuscar.reset();
    break;
    // Busqueda de dublicados de forzar subir acta defunciones
    case "forzarSubirDef":
    
    this.tarjetaService.getDuplicadosDef(this.globalFormbuscar.get('crip')?.value).subscribe(data => {
      
      let infoEnviada = {
        registro: data,
        habilitarForm: false,
        tarea: 'busquedaCrip'
        
      }
      this.registroDevuelto.emit(infoEnviada);
      this.limpiar();
      // this.toastr.success('Registro encontrado ', "Operación exitosa" , {
      //   closeButton: true,
      //   disableTimeOut: false,
      // })
      
    },
    error => {
      this.toastr.error(error.error , 'Opeación Fallida',{
        closeButton: true,
        disableTimeOut: false,

      });
      
      
      this.registroDevuelto.emit('error');
    });
    

    // this.globalFormbuscar.reset();
    break;
    default:
        console.log('Otra opción....!');
        this.registroDevuelto.emit('error');
    break;
        
  }

}


}
