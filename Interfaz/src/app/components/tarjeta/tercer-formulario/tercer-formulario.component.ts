import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { map, Observable, startWith, timeout } from 'rxjs';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';
import { NrcPais } from 'src/app/models/NrcPais.model';
import { Nrc_Nacimientos } from 'src/app/models/NrcNacimientos';
import Swal  from "sweetalert2";

@Component({
  selector: 'app-tercer-formulario',
  templateUrl: './tercer-formulario.component.html',
  styleUrls: ['./tercer-formulario.component.css']
})
export class TercerFormularioComponent implements OnInit {
  
  formCambioNacionalidad: FormGroup;
  
  //Guardan los paises que coincidan con lo buscado en autocomplete
  optionsPa!: NrcPais[];
  optionsMa!: NrcPais[];

  //Guarda id de pais seleccionado
  paNuevaNacionalidad!: number;
  maNuevaNacionalidad!: number;
  
 pacodigo!: number;
 macodigo!:number;



@Output() enviarRegistro: EventEmitter<any> = new EventEmitter();

@Input()datosRetornados: any;


firstFormGroup: FormGroup = this.formBuilder.group({firstCtrl: ['']});
secondFormGroup: FormGroup = this.formBuilder.group({secondCtrl: ['']});

constructor(private formBuilder: FormBuilder
  , private toastr: ToastrService
  , private servicioeditar: TarjetaServiceService) { 
  this.formCambioNacionalidad = this.formBuilder.group({
    peNombres: [{value:'' , disabled:true} , [Validators.required]],
    pePrimerapellido: [{value:'' , disabled:true} , [Validators.required]],
    peSegundoapellido: [{value:'' , disabled:true} , [Validators.required]],
    peSexo: [{value:'' , disabled:true} , [Validators.required]],
    peFechanacimiento: [{value:'' , disabled:true} , [Validators.required]],
    peEntidadnacimiento: [{value:'' , disabled:true} , [Validators.required]],


    paNombres: [{value:'' , disabled:true} , [Validators.required]],
    paPrimerapellido: [{value:'' , disabled:true} , [Validators.required]],
    paSegundoapellido: [{value:'' , disabled:true} , [Validators.required]],
    paNacionalidad : [{value:'' , disabled:false} , [Validators.required]],
    paCurp : [{value:'' , disabled:true} , [Validators.required]],


    maNombres: [{value:'' , disabled:true} , [Validators.required]],
    maPrimerapellido: [{value:'' , disabled:true} , [Validators.required]],
    maSegundoapellido: [{value:'' , disabled:true} , [Validators.required]],
    maNacionalidad : [{value:'' , disabled:false} , [Validators.required]],
    maCurp : [{value:'' , disabled:true} , [Validators.required]],

  })
}

ngOnInit(): void {
  // if(this.datosRetornados.habilitarForm === true){
  //   this.actualizar();
  // } 

  //Inicializar variables de nacionalidad con valores del registro encontrado
  this.paNuevaNacionalidad = this.datosRetornados.paNacionalidad;
  this.maNuevaNacionalidad = this.datosRetornados.maNacionalidad;
  
 this.formCambioNacionalidad.patchValue(this.datosRetornados);
 
 
 this.servicioeditar.getNrcpaiscodigo(this.datosRetornados.paNacionalidad).subscribe( datos =>  {
   this.paNuevaNacionalidad = datos.paiCodigo;
   this.formCambioNacionalidad.patchValue({paNacionalidad:datos.paiDescripcion});
 })

  this.servicioeditar.getNrcpaiscodigo(this.datosRetornados.maNacionalidad).subscribe( datos =>  {
    this.maNuevaNacionalidad = datos.paiCodigo;
   this.formCambioNacionalidad.patchValue({maNacionalidad:datos.paiDescripcion});
 })

  //Para llenar las opciones del autocomplete de Nacionalidad (Padre)
  this.formCambioNacionalidad.controls["paNacionalidad"].valueChanges.subscribe(value => {
    // console.log(value);
    if(value.length > 2){
      this.servicioeditar.getPaisDesc(value).subscribe(pais => {
        this.optionsPa = pais;
        // console.log(this.optionsPa);
      });
    }
    else{
      this.optionsPa = []
    }

  });
  //Para llenar las opciones del autocomplete de Nacionalidad (Madre)
  this.formCambioNacionalidad.controls["maNacionalidad"].valueChanges.subscribe(value => {
    // console.log(value);
    if(value.length > 2){
      this.servicioeditar.getPaisDesc(value).subscribe(pais => {
        this.optionsMa = pais;
        // console.log(this.optionsMa);
      });
    }
    else{
      this.optionsMa = []
    }

  });
  

}

//Para guardar el id del pais seleccionado en el Autocomplete de nacionalidad del padre
cambiarPaisPa(option: NrcPais){

  this.paNuevaNacionalidad = option.paiCodigo;
  console.log("NACIONALIDAD - PADRE" , option , this.paNuevaNacionalidad);
}

//Para guardar el id del pais seleccionado en el Autocomplete de nacionalidad del madre
cambiarPaisMa(option: NrcPais){

  this.maNuevaNacionalidad = option.paiCodigo;
  console.log("NACIONALIDAD - MADRE" , option , this.maNuevaNacionalidad);
}



guardarCambios() {
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
      this.enviarRegistro.emit(undefined);
      console.log("Form:" , this.formCambioNacionalidad.value);
  
      const formNacionalidad: Nrc_Nacimientos = this.datosRetornados;
    
      formNacionalidad.maNacionalidad = this.maNuevaNacionalidad;
      formNacionalidad.paNacionalidad = this.paNuevaNacionalidad;
      // formNacionalidad.maNacionalidad = parseInt(this.formCambioNacionalidad.controls["maNacionalidad"].value);
      // formNacionalidad.paNacionalidad = parseInt(this.formCambioNacionalidad.controls["paNacionalidad"].value);
    
      console.log("Variable para guardar form:" , formNacionalidad);
      
      this.servicioeditar.putNrcNacimiento(this.datosRetornados.cadena, formNacionalidad).subscribe(datos => {
        if(datos !== null && datos !== undefined){
          this.toastr.success("Cambio de nacionalidad exitoso", "Cambio de nacionalidad" , {
            closeButton: true,
            timeOut: 7000,
          });
         
        }
      
        else{
          this.toastr.error("Ocurrio un error al actualizar ","Error al actualizar",{
            timeOut: 7000,
            closeButton: true,
      
          });
        }
      })
    }
  } )

 
  }
  
campoNoEsValido(campo: string){
  return this.formCambioNacionalidad.controls[campo].errors &&
          this.formCambioNacionalidad.controls[campo].touched
}
// actualizar(){
  
  
// }

cancelar(){
  this.enviarRegistro.emit(null);
  
} 


  

}
