using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataGatherer.Models.Domain;

namespace DataGatherer.Models.DAL
{
    class ItemMap : EntityTypeConfiguration<MyItem>
    {
        
    }
}
