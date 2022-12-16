export interface NrcPais{
    paiCodigo :number;
    paiNacionalidad :string;
    paiDescripcion :string;
    paiUsuarioCreacion :string;
    paiFechaCreacion :Date;
    paiUsuarioModificacion :string | null;
    paiFechaModificacion? :Date | null;
    paiCveNacionalidad :string | null;
}
