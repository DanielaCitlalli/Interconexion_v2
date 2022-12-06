import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { map, Observable, startWith } from 'rxjs';
import { Nrc_Nacimientos } from 'src/app/models/NrcNacimientos';
import { NrcPais } from 'src/app/models/NrcPais.model';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-tercer-formulario',
  templateUrl: './tercer-formulario.component.html',
  styleUrls: ['./tercer-formulario.component.css']
})
export class TercerFormularioComponent implements OnInit {
  
  formCambioNacionalidad: FormGroup;
  
   
  

// guardarCambios() {
// throw new Error('Method not implemented.');
// }

@Output() enviarRegistro: EventEmitter<any> = new EventEmitter();

@Input()datosRetornados: any;


  

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
  if(this.datosRetornados.habilitarForm === true){
   this.actualizar();
    
   
  this.formCambioNacionalidad.get('paNacionalidad')?.disable();
  this.formCambioNacionalidad.get('maNacionalidad')?.disable();
  }
  console.log(this.datosRetornados);
  this.formCambioNacionalidad.patchValue(this.datosRetornados);

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
      this.enviarRegistro.emit(undefined);

      const formNacionalidad: Nrc_Nacimientos = this.datosRetornados.registro;
      formNacionalidad.panacionalidad = this.formCambioNacionalidad.get('paNacionalidad')?.value;
      formNacionalidad.manacionalidad = this.formCambioNacionalidad.get('maNacionalidad')?.value;
  
      this.servicioeditar.postNrcpais(this.datosRetornados.registro.cadena).subscribe(data => {
  
        if(data ){
          this.toastr.success("Cambio la Nacionalida", " Cambio de Nacionalidad exitosa " , {
            closeButton: true,
            timeOut: 7000,
          });
          this.enviarRegistro.emit(data);
          
          
          const formpais: Nrc_Nacimientos = {
            numeroacta:0,
            anioregistro:0,
            tipodocumento:0,
            entidadregistro:0,
            municipioregistro:0,
            oficilia:0,     
            actabis:"",
            cadena:"",
            cofecharegistro:null,
            collaveregistrocivil:'',
            cofoja: 0,
            cotomo:0,
            colibro:0,
            imnombreoriginalimagen:null,
            imarchivo:'',
            otnotasmarginales:'',
            otcrip:'',
            Otvivoomuerto:'',
            peprimerapellido:'',
            pesegundoapellido:'',
            penombres:'',
            peedad:0,
            pesexo:'',
            pefechanacimiento:null, 
            pefechanacimientoinc:'',
            peentidadnacimiento:0,
            pemunicipionacimiento:0,
            pelocalidadnacimiento:'',
            penacionalidad:0,
            pepaisnacimiento:0,
            pecurp :'',
            paprimerapellido  :'',
            pasegundoapellido:'',
            panombres:'',
            paedad:0,
            pasexo:'',
            pafechanacimiento:null,
            pafechanacimientoinc:'',
            paentidadnacimiento:0,
            pamunicipionacimiento:0,
            palocalidadnacimiento:'',
            panacionalidad:0,
            papaisnacimiento:0,
            pacurp :'',
            panumeroacta:0,
            paanioregistro:0,
            patipodocumento:0,
            paentidadregistro:0,
            pamunicipioregistro:0,
            paoficilia:0,
            paactabis:'',
            manumeroacta:0,
            maanioregistro:0,
            matipodocumento:0,
            maentidadregistro:0,
            mamunicipioregistro:0,
            maoficilia:0,
            maactabis:'',
            maprimerapellido  :'',
            masegundoapellido:'',
            manombres:'',
            maedad:0,
            masexo:'',
            mafechanacimiento:null,
            mafechanacimientoinc:'',
            maentidadnacimiento:0,
            mamunicipionacimiento:0,
            malocalidadnacimiento:'',
            manacionalidad:0,
            mapaisnacimiento:0,
            macurp :'',
            cnfechaactualizacion:null,
            cnfechaactualizacioninc: null,
            cnfechacaptura:null,
            oterrororigen: null,
            otfecharegistronacimientoinc:'',
            otfirma:'',
            otsello:'',
            tmpfecha:null,
            otcertificadona: null,
            nactoid:0,
            tipocadena:0,
            cotipo:null,
            cofechaoriginal:null,
            cotranscripcion:'',
            cosoporte:''
          }
          this.servicioeditar.postNrcNacimiento(formpais).subscribe(data=> {
  
              this.enviarRegistro.emit(data);
              this.toastr.success("Actualizacion de tabla NrcPais " , " Éxito" , {
                closeButton: true,
                timeOut: 7000,
              })
              
            },error => {
              this.toastr.error("Error al actualizar tabla tabla NrcPais", " Error" , {
                timeOut: 7000,
                closeButton: true,
              })
            })
          
        }
        else{
          this.toastr.error("Ocurrio un error al actualizar ","Error de altualizar",{
            timeOut: 7000,
            closeButton: true,
  
          });
        }
  
  
    } , error => {
      this.toastr.error("Error al actualizar sexo","Error de altualizar Nacionalidad ",{
        timeOut: 7000,
        closeButton: true,
  
      });
    })
    }
  })

  
}

 
campoNoEsValido(campo: string){
  return this.formCambioNacionalidad.controls[campo].errors &&
          this.formCambioNacionalidad.controls[campo].touched
}
 actualizar(){
  this.formCambioNacionalidad.patchValue(this.datosRetornados.registro);
  
 }

// cancelar(){
//   this.enviarRegistro.emit(null);
// } 


  

}
