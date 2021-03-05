//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profe : IEquatable<Profe>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profe()
        {
            this.FCTs = new HashSet<FCT>();
        }
    
        public string Id { get; set; }
        public string Nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FCT> FCTs { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Profe);
        }

        public Profe(string id, string nombre, ICollection<FCT> fCTs)
        {
            Id = id;
            Nombre = nombre;
            FCTs = fCTs;
        }

        public bool Equals(Profe other)
        {
            return other != null &&
                   Id.ToLower() == other.Id.ToLower() &&
                   Nombre.ToLower() == other.Nombre.ToLower();
        }

        public override int GetHashCode()
        {
            int hashCode = 131340583;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            return hashCode;
        }
    }
}
