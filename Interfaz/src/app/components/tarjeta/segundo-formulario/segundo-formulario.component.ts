import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Genericos } from 'src/app/models/Genericos.model';
import { Nrc_Matrimonios } from 'src/app/models/Nrc_Matrimonios';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';
import { ToastrService } from 'ngx-toastr';
import { CirrTa09Mapeticion } from 'src/app/models/CirrTa09Mapeticion.model';
import Swal  from "sweetalert2";
import { NrcPais } from 'src/app/models/NrcPais.model';

@Component({
  selector: 'app-segundo-formulario',
  templateUrl: './segundo-formulario.component.html',
  styleUrls: ['./segundo-formulario.component.css']
})
export class SegundoFormularioComponent implements OnInit {

  formCambioSexo: FormGroup;
  formCambioNacionalidadM: FormGroup;
  optionsNa!:NrcPais[];
  optionsNa2!:NrcPais[];
  longPais: string = '';
  longPais2: string = '';
  NuevaNacionalidad!: number;
  NuevaNacionalidad2!: number;

  listSexo: Genericos[] = [
    { valor: 'F', nombre: 'Femenino' },
    { valor: 'M', nombre: 'Masculino'}
  ]

  @Input()datosRetornados: any;
  @Input() CambiarP: any;
  @Output() enviarRegistro: EventEmitter<any> = new EventEmitter();
  

  constructor(private formBuilder: FormBuilder
    , private toastr: ToastrService
    , private servicioeditar: TarjetaServiceService) { 
    this.formCambioSexo = this.formBuilder.group({
      p1Nombres: [{value:'' , disabled:true} , [Validators.required]],
      p1Primerapellido: [{value:'' , disabled:true} , [Validators.required]],
      p1Segundoapellido: [{value:'' , disabled:true} , [Validators.required]],
      p1Sexo: [{value:'' , disabled:false} , [Validators.required]],
      

      p2Nombres: [{value:'' , disabled:true} , [Validators.required]],
      p2Primerapellido: [{value:'' , disabled:true} , [Validators.required]],
      p2Segundoapellido: [{value:'' , disabled:true} , [Validators.required]],
      
      p2Sexo: [{value:'' , disabled:false} , [Validators.required]],
      
     
    })

    this.formCambioNacionalidadM = this.formBuilder.group({
      p1Nombres: [{value:'' , disabled:true} , [Validators.required]],
      p1Primerapellido: [{value:'' , disabled:true} , [Validators.required]],
      p1Segundoapellido: [{value:'' , disabled:true} , [Validators.required]],
      p1Sexo: [{value:'' , disabled:true} , [Validators.required]],
      p1Nacionalidad: [{value:'' , disabled:false} , [Validators.required]],
      
      p2Nombres: [{value:'' , disabled:true} , [Validators.required]],
      p2Primerapellido: [{value:'' , disabled:true} , [Validators.required]],
      p2Segundoapellido: [{value:'' , disabled:true} , [Validators.required]],
      
      p2Sexo: [{value:'' , disabled:true} , [Validators.required]],
      p2Nacionalidad: [{value:'' , disabled:false} , [Validators.required]],
      
     
    })
  }

  ngOnInit(): void {
    if(this.datosRetornados.habilitarForm === true){
      this.actualizar();
      
    }
    
    this.formCambioSexo.get('p1_nombres')?.disable();
//Cambiar la Nacionalida de Contrayente 1
    this.servicioeditar.getNrcpaiscodigo(this.datosRetornados.registro.p1Nacionalidad).subscribe( datos =>  {
  
      //validacion para deshabilitar boton de actualizar
      this.longPais = datos.paiDescripcion;
   
      this.NuevaNacionalidad = datos.paiCodigo;
      this.formCambioNacionalidadM.patchValue({p1Nacionalidad:datos.paiDescripcion});
      
    })
    //Cambiar la Nacionalida de Contrayente 2
    this.servicioeditar.getNrcpaiscodigo(this.datosRetornados.registro.p2Nacionalidad).subscribe( datos =>  {
  
      //validacion para deshabilitar boton de actualizar
      this.longPais2 = datos.paiDescripcion;
   
      this.NuevaNacionalidad2 = datos.paiCodigo;
      this.formCambioNacionalidadM.patchValue({p2Nacionalidad:datos.paiDescripcion});
      
    })
   //contrayecte 1
     //Para llenar las opciones del autocomplete de Nacionalidad (Padre). Tambien se llama este metodo cuando se cambia el valor del input
  this.formCambioNacionalidadM.controls["p1Nacionalidad"].valueChanges.subscribe(value => {

    //Este if solo es para evaluar la primera vez que carga o se selecciona una nueva nacionalidad, por eso cuando entra al if, longPais se vuelve ''. 
    //Para no permitir que igualando el tamaño con cualquier caracter se habilite el boton de actualizar
    if(value.length != this.longPais.length){
      this.longPais = '';
      this.formCambioNacionalidadM.controls["p1Nacionalidad"].setErrors({'incorrect': true});
    }

    if(value.length > 2){
      this.servicioeditar.getPaisDesc(value).subscribe(pais => {
        this.optionsNa = pais;
      });
    }
    else{
      this.optionsNa = []
    }

  });

  //contrayecte 2
     //Para llenar las opciones del autocomplete de Nacionalidad (Padre). Tambien se llama este metodo cuando se cambia el valor del input
     this.formCambioNacionalidadM.controls["p2Nacionalidad"].valueChanges.subscribe(value => {
      
      //Este if solo es para evaluar la primera vez que carga o se selecciona una nueva nacionalidad, por eso cuando entra al if, longPais se vuelve ''. 
      //Para no permitir que igualando el tamaño con cualquier caracter se habilite el boton de actualizar
      if(value.length != this.longPais2.length){
        this.longPais2 = '';
        this.formCambioNacionalidadM.controls["p2Nacionalidad"].setErrors({'incorrect': true});
        
      }
  
      if(value.length > 2){
        this.servicioeditar.getPaisDesc(value).subscribe(pais => {
          this.optionsNa2 = pais;
        });
      }
      else{
        this.optionsNa2 = []
      }
  
    });
    
  }

  guardarCambios(){
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
        if(this.CambiarP){
          this.enviarRegistro.emit(undefined);

          //En caso de guardar nacionalidades, usar variable que guarda codigo correspondiente a su respectiva nacionalidad
          const formMatrimonioNacionalidad: Nrc_Matrimonios = this.datosRetornados.registro;
          formMatrimonioNacionalidad.p1nacionalidad = this.NuevaNacionalidad;
          formMatrimonioNacionalidad.p2nacionalidad = this.NuevaNacionalidad2;
          formMatrimonioNacionalidad.p1sexo = this.formCambioNacionalidadM.get('p1Sexo')?.value;
          formMatrimonioNacionalidad.p2sexo = this.formCambioNacionalidadM.get('p2Sexo')?.value;
      
          this.servicioeditar.putNrcMatrimonios(this.datosRetornados.registro.cadena, '1', formMatrimonioNacionalidad).subscribe(data => {
      
            if(data !== null && data !== undefined){
              this.toastr.success("Se actualizó el cambio de nacionalidad", "Operación Exitosa" , {
                closeButton: true,
                timeOut: 7000,
              });
              this.enviarRegistro.emit(data);
              
              
              const form09f: CirrTa09Mapeticion = {
                ta09EOid: 0,
                ta09ESecuencia: null,
                ta09EPrioridad: 1,
                ta09EOperacionacto: 1,
                ta09CCadena: data.cadena ,
                ta09FEntrada: null,
                ta09EEstatus: 0,
                ta07EEstadodest: null,
                ta07EOiddestino: null,
                ta07ESolicitarimagen: null,
                ta09FAtencion: null,
                ta09ECuantos: 0
        
              }
              this.servicioeditar.postCirrTa09Mapeticion(form09f).subscribe(data=> {
      
                  this.enviarRegistro.emit(data);
                  this.toastr.success("Se actualizó de tabla CIRR_TA09_MAPETICION " , " Operación Exitosa" , {
                    closeButton: true,
                    timeOut: 7000,
                  })
                  
                },error => {
                  this.toastr.error("Ocurrió un error al actualizar tabla CIRR_TA09_MAPETICION", " Error" , {
                    timeOut: 7000,
                    closeButton: true,
                  })
                })
              
            }
            else{
              this.toastr.error("Ocurrió un error al actualizar ","Operación Fallida",{
                timeOut: 7000,
                closeButton: true,
      
              });
            }
      
      
        } , error => {
          this.toastr.error("Ocurrió un error al actualizar matrimonios111"," Operación Fallida ",{
            timeOut: 7000,
            closeButton: true,
      
          });
        })


        }
        else{
          this.enviarRegistro.emit(undefined);

        const formMatrimonio: Nrc_Matrimonios = this.datosRetornados.registro;
        formMatrimonio.p1sexo = this.formCambioSexo.get('p1Sexo')?.value;
        formMatrimonio.p2sexo = this.formCambioSexo.get('p2Sexo')?.value;
    
        this.servicioeditar.putNrcMatrimonios(this.datosRetornados.registro.cadena, '0', formMatrimonio).subscribe(data => {
    
          if(data !== null && data !== undefined){
            this.toastr.success("Se actualizó el cambio de sexo", "Operación Exitosa" , {
              closeButton: true,
              timeOut: 7000,
            });
            this.enviarRegistro.emit(data);
            
            
            const form09f: CirrTa09Mapeticion = {
              ta09EOid: 0,
              ta09ESecuencia: null,
              ta09EPrioridad: 1,
              ta09EOperacionacto: 1,
              ta09CCadena: data.cadena ,
              ta09FEntrada: null,
              ta09EEstatus: 0,
              ta07EEstadodest: null,
              ta07EOiddestino: null,
              ta07ESolicitarimagen: null,
              ta09FAtencion: null,
              ta09ECuantos: 0
      
            }
            this.servicioeditar.postCirrTa09Mapeticion(form09f).subscribe(data=> {
    
                this.enviarRegistro.emit(data);
                this.toastr.success("Se actualizó de tabla CIRR_TA09_MAPETICION " , " Operación Exitosa" , {
                  closeButton: true,
                  timeOut: 7000,
                })
                
              },error => {
                this.toastr.error("Ocurrió un error al actualizar tabla CIRR_TA09_MAPETICION", " Error" , {
                  timeOut: 7000,
                  closeButton: true,
                })
              })
            
          }
          else{
            this.toastr.error("Ocurrió un error al actualizar ","Operación Fallida",{
              timeOut: 7000,
              closeButton: true,
    
            });
          }
    
    
      } , error => {
        this.toastr.error("Ocurrió un error al actualizar matrimonios"," Operación Fallida ",{
          timeOut: 7000,
          closeButton: true,
    
        });
      }) 
        }
       
      }
    })

    
  }

  campoNoEsValido(campo: string){
    return this.formCambioSexo.controls[campo].errors &&
            this.formCambioSexo.controls[campo].touched
  }

  actualizar(){
    this.formCambioSexo.patchValue(this.datosRetornados.registro);

    this.formCambioNacionalidadM.patchValue(this.datosRetornados.registro);
    
  }
  
  cancelar(){
    this.enviarRegistro.emit(null);
  }
 cambiarNa(pais:NrcPais){
  this.longPais = pais.paiDescripcion;

  this.NuevaNacionalidad = pais.paiCodigo;
 }

 cambiarNa2(pais:NrcPais){
  this.longPais2 = pais.paiDescripcion;

  this.NuevaNacionalidad2 = pais.paiCodigo;
 }
}
