import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NrcPais } from 'src/app/models/NrcPais.model';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';
import Swal  from "sweetalert2";
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-cuarto-formulario',
  templateUrl: './cuarto-formulario.component.html',
  styleUrls: ['./cuarto-formulario.component.css']
})
export class CuartoFormularioComponent implements OnInit {
  
  formPais: FormGroup;
  options!:NrcPais[];


  @Input() Editable: any;
  @Output() enviarDatos: EventEmitter<any> = new EventEmitter();

  constructor(private formBuilder: FormBuilder, private tarjetaService: TarjetaServiceService, private toastService: ToastrService) {
    this.formPais = this.formBuilder.group({
      paiCodigo:[{value:'' , disabled: true} , [Validators.required , Validators.minLength(1) , Validators.maxLength(3) , Validators.pattern(this.tarjetaService.rxNumeros)]],
      paiNacionalidad:[{value:'' , disabled: false}],
      paiDescripcion:[{value:'' , disabled: false} , [Validators.required , Validators.minLength(1) , Validators.maxLength(30) , Validators.pattern(this.tarjetaService.rxLetrasEspacio)]],
      paiUsuarioCreacion:[{value:'' , disabled: false}],
      paiFechaCreacion:[{value:'' , disabled: false}],
      paiUsuarioModificacion:[{value:'' , disabled: false}],
      paiFechaModificacion:[{value:'' , disabled: false}],
      paiCveNacionalidad:[{value:'' , disabled: false} , [Validators.required , Validators.minLength(1) , Validators.maxLength(3) , Validators.pattern(this.tarjetaService.rxCveNacionalidad)]],
      autocompleteDescripcion: [{value: '', disabled:false}]
    });
   }

  ngOnInit(): void {

    // console.log('this.formPais.paiFechaCreacion');

    //Para habilitar campo Codigo, cuando se quiera agregar una nueva nacionalidad
    if(!this.Editable){
      this.formPais.controls['paiCodigo'].enable()
    }


    this.formPais.controls["autocompleteDescripcion"].valueChanges.subscribe(value => {

      //Este if solo es para evaluar la primera vez que carga o se selecciona una nueva nacionalidad, por eso cuando entra al if, longPais se vuelve ''. 
      //Para no permitir que igualando el tamaño con cualquier caracter se habilite el boton de actualizar
     
      if(value!== null ){
          if(value.length > 2){
            this.tarjetaService.getPaisDesc(value).subscribe(pais => { 
              this.options = pais;

            
            });
          }
          else{
            this.options = [];
            
          }
      }

      
  
    });
  

  }
  cambiarPaisPa(pais:NrcPais){

    //validacion para deshabilitar boton de actualizar
    // this.tarjetaService.getNrcpaiscodigo().subscribe((data) => {
    //   this.registroTa09 = data;
      
    // });

    // console.log(this.options);
    this.formPais.patchValue({
      paiCodigo: pais.paiCodigo,
      paiNacionalidad: pais.paiNacionalidad,
      paiDescripcion: pais.paiDescripcion,
      paiUsuarioCreacion: pais.paiUsuarioCreacion,
      paiFechaCreacion: pais.paiFechaCreacion,
      paiUsuarioModificacion: pais.paiUsuarioModificacion,
      paiFechaModificacion: pais.paiFechaModificacion,
      paiCveNacionalidad: pais.paiCveNacionalidad
    });
    
  }

  cancelar(){
    this.enviarDatos.emit(null); 
  }

  guardarCambios(){

    const fecha = new Date();
    let fechaCreacion;

    if(this.Editable){
      fechaCreacion = this.formPais.controls["paiFechaCreacion"].value;
    }
    else{
      fechaCreacion = new Date(`${fecha.toDateString()}`);
    }

    const formPaises: NrcPais = {
      paiCodigo : parseInt(this.formPais.controls["paiCodigo"].value),
      paiNacionalidad : this.formPais.controls["paiDescripcion"].value.toUpperCase(),
      paiDescripcion : this.formPais.controls["paiDescripcion"].value.toUpperCase(),
      paiUsuarioCreacion : 'NRCIVIL',
      paiFechaCreacion :  fechaCreacion,
      paiUsuarioModificacion : null,
      paiFechaModificacion: null,
      paiCveNacionalidad : this.formPais.controls["paiCveNacionalidad"].value.toUpperCase(),
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
  if(result.isConfirmed){

     
      if (this.Editable) {
      
        this.tarjetaService.putNacionalidad( formPaises.paiCodigo, formPaises ).subscribe(res => {
          this.toastService.success("Se editó Nacionalidad" , " Operación Exitosa" , {
            closeButton: true,
            timeOut: 7000,
          })
  
          this.formPais.reset();
        }, error => {
          this.enviarDatos.emit(undefined);
          this.toastService.error("Ocurrió un error al editar nacionalidad" , "Opeación Fallida")
          
         
        });
      }
      else{
        this.tarjetaService.postNacionalidad(formPaises).subscribe(res => {
          this.toastService.success("Se agregó nacionalidad " , "Operación Exitosa" , {
            closeButton: true,
            timeOut: 7000
          })

          this.formPais.reset();
        }, error => {
          this.enviarDatos.emit(undefined);
          this.toastService.error("Ocurrió un error al agregar nacionalidad" , "Opeación Fallida");
        });
      }


  }

  else{
    this.toastService.warning(" " , "Operación Cancelada");
    
  }
    })
  

    
  }


}
