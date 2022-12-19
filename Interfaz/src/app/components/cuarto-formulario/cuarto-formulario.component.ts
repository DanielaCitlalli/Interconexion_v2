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


  @Input() Editable: any;
  @Output() enviarDatos: EventEmitter<any> = new EventEmitter();

  constructor(private formBuilder: FormBuilder, private tarjetaService: TarjetaServiceService, private toastService: ToastrService) {
    this.formPais = this.formBuilder.group({
      paiCodigo:[{value:'' , disabled: false} , [Validators.required , Validators.minLength(1) , Validators.maxLength(3) , Validators.pattern(this.tarjetaService.rxNumeros)]],
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
  }

  cancelar(){
    this.enviarDatos.emit(null); 
  }

  guardarCambios(){

    const fecha = new Date();

    const formPaises: NrcPais = {
      paiCodigo : parseInt(this.formPais.controls["paiCodigo"].value),
      paiNacionalidad : this.formPais.controls["paiDescripcion"].value,
      paiDescripcion : this.formPais.controls["paiDescripcion"].value,
      paiUsuarioCreacion : 'NRCIVIL',
      paiFechaCreacion :  new Date(`${fecha.toDateString()}`),
      paiUsuarioModificacion : null,
      paiFechaModificacion: null,
      paiCveNacionalidad : this.formPais.controls["paiCveNacionalidad"].value,
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
      
      this.tarjetaService.postNacionalidad(formPaises).subscribe(res => {
        
        this.toastService.success("Se agregó una nueva nacionalidad" , " Éxito" , {
          closeButton: true,
          timeOut: 7000,
        })

        this.formPais.reset();
      }, error => {
        this.toastService.error("Error al agregar una nueva nacionalidad" , "Error al agregar")
      });
    })
    

    
  }


}
