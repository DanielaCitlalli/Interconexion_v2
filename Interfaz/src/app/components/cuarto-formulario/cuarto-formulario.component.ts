import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-cuarto-formulario',
  templateUrl: './cuarto-formulario.component.html',
  styleUrls: ['./cuarto-formulario.component.css']
})
export class CuartoFormularioComponent implements OnInit {
  
  formPais: FormGroup;

  @Input() Editable: any;
  @Output() enviarDatos: EventEmitter<any> = new EventEmitter();

  constructor(private formBuilder: FormBuilder) {
    this.formPais = this.formBuilder.group({
      paiCodigo:[{value:'' , disabled: false} , [Validators.required]],
      paiNacionalidad:[{value:'' , disabled: false} , [Validators.required]],
      paiDescripcion:[{value:'' , disabled: false} , [Validators.required]],
      paiUsuarioCreacion:[{value:'' , disabled: false} , [Validators.required]],
      paiFechaCreacion:[{value:'' , disabled: false} , [Validators.required]],
      paiUsuarioModificacion:[{value:'' , disabled: false} , [Validators.required]],
      paiFechaModificacion:[{value:'' , disabled: false} , [Validators.required]],
      paiCveNacionalidad:[{value:'' , disabled: false} , [Validators.required]],
      autocompleteDescripcion: [{value: '', disabled:false} , [Validators.required]]
    });
   }

  ngOnInit(): void {
  }

  cancelar(){
    this.enviarDatos.emit(null);
    console.log('hola 123');
    
  }


}
