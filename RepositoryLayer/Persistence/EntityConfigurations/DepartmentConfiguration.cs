using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DomainLayer.Models.Department;

namespace RepositoryLayer.Persistence.EntityConfigurations
{
    public class DepartmentConfiguration : EntityTypeConfiguration<DepartmentModel> , IConfiguration
    {
        public Action AddConfig { get; private set; }

        public DepartmentConfiguration()
        {
            ApplyConfigurations();
        }

        private void ConfigureID()
        {
            Property(d => d.ID)
                .IsRequired();                
        }

        private void ConfigureName()
        {
            Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(255);                
        }

        private void ConfigureUrl()
        {
            Property(d => d.Url)
                .IsRequired()
                .HasMaxLength(255);
        }

        private void ConfigurePhoneNumber()
        {
            Property(d => d.PhoneNumber)
                .IsRequired()
                .HasMaxLength(255);
        }

        private void ConfigureEmail()
        {
            Property(d => d.Email)
                .IsRequired()
                .HasMaxLength(255);
        }

        private void ConfigureCityLocation()
        {
            Property(d => d.CityLocation)
                .IsRequired()
                .HasMaxLength(255);
        }

        private void ConfigureStateLocation()
        {
            Property(d => d.StateLocation)
                .IsRequired()
                .HasMaxLength(255);
        }

        private void ApplyConfigurations()
        {
            AddConfig += ConfigureID;
            AddConfig += ConfigureName;
            AddConfig += ConfigureUrl;
            AddConfig += ConfigurePhoneNumber;
            AddConfig += ConfigureEmail;
            AddConfig += ConfigureCityLocation;
            AddConfig += ConfigureStateLocation;
            AddConfig.Invoke();
        }
    }
}
