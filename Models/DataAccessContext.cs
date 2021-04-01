using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ServicesOnLineAPI
{
     public partial class DataAccessContext : DbContext
     {
          public DataAccessContext()
          {
          }

          public DataAccessContext(DbContextOptions<DataAccessContext> options)
              : base(options)
          {
          }

          public virtual DbSet<Address> Addresses { get; set; }
          public virtual DbSet<Cctransaction> Cctransactions { get; set; }
          public virtual DbSet<ContactMechanism> ContactMechanisms { get; set; }
          public virtual DbSet<ContactType> ContactTypes { get; set; }
          public virtual DbSet<Entity> Entity { get; set; }
          public virtual DbSet<EntityType> EntityTypes { get; set; }
          public virtual DbSet<GeoCity> GeoCities { get; set; }
          public virtual DbSet<GeoNation> GeoNations { get; set; }
          public virtual DbSet<GeoRegion> GeoRegions { get; set; }
          public virtual DbSet<Location> Locations { get; set; }
          public virtual DbSet<LocationsType> LocationsTypes { get; set; }
          public virtual DbSet<Order> Orders { get; set; }
          public virtual DbSet<OrdersHeader> OrdersHeaders { get; set; }
          public virtual DbSet<PaymentHist> PaymentHist { get; set; }
          public virtual DbSet<Person> Persons { get; set; }
          public virtual DbSet<PersonsRole> PersonsRoles { get; set; }
          public virtual DbSet<PriceList> PriceLists { get; set; }
          public virtual DbSet<Promotion> Promotions { get; set; }
          public virtual DbSet<Property> Properties { get; set; }
          public virtual DbSet<PropertyType> PropertyTypes { get; set; }
          public virtual DbSet<Role> Roles { get; set; }
          public virtual DbSet<Service> Services { get; set; }
          public virtual DbSet<ServiceMedia> ServiceMedia { get; set; }
          public virtual DbSet<ServiceSched> ServiceScheds { get; set; }
          public virtual DbSet<ServicesType> ServicesTypes { get; set; }
          public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
          public virtual DbSet<State> States { get; set; }
          public virtual DbSet<TransactState> TransactStates { get; set; }
          public virtual DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
          public virtual DbSet<VAddress> VAddresses { get; set; }
          public virtual DbSet<VAddressForAllEntity> VAddressForAllEntities { get; set; }
          public virtual DbSet<VContactMechanismForLocation> VContactMechanismForLocations { get; set; }
          public virtual DbSet<VEntity> VEntities { get; set; }
          public virtual DbSet<VOrderHeader> VOrderHeaders { get; set; }
          public virtual DbSet<VOrdersDetail> VOrdersDetails { get; set; }
          public virtual DbSet<VPersonContactMechnaism> VPersonContactMechnaisms { get; set; }
          public virtual DbSet<VPersonsRole> VPersonsRoles { get; set; }
          public virtual DbSet<VPropertiesContactMechanism> VPropertiesContactMechanisms { get; set; }
          public virtual DbSet<VProperty> VProperties { get; set; }
          public virtual DbSet<VService> VServices { get; set; }
          public virtual DbSet<View1> View1s { get; set; }
          public virtual DbSet<View2> View2s { get; set; }

          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
               if (!optionsBuilder.IsConfigured)
               {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                    //optionsBuilder.UseSqlServer("Server= LAPTOP-C7MGIJKK;Database=ServicesOnLine;Trusted_Connection=True;");
               }
          }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
               modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

               modelBuilder.Entity<Address>(entity =>
               {
                    entity.Property(e => e.Address1)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.Address2)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.City)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.County)
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.ZipCode)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.HasOne(d => d.State)
                     .WithMany(p => p.Addresses)
                     .HasForeignKey(d => d.StateId)
                     .HasConstraintName("fk_StateId");
               });

               modelBuilder.Entity<Cctransaction>(entity =>
               {
                    entity.HasKey(e => e.CctransactId)
                     .HasName("PK__CCTransa__0BD53013DA920347");

                    entity.ToTable("CCTransactions");

                    entity.Property(e => e.CctransactId).HasColumnName("CCTransactId");

                    entity.Property(e => e.Amount).HasColumnType("money");

                    entity.Property(e => e.Ccresponse)
                     .HasMaxLength(2)
                     .IsUnicode(false)
                     .HasColumnName("CCResponse");

                    entity.Property(e => e.ResponseDate).HasColumnType("datetime");

                    entity.HasOne(d => d.OrdersHdr)
                     .WithMany(p => p.Cctransactions)
                     .HasForeignKey(d => d.OrdersHdrId)
                     .HasConstraintName("FK_OrdersHdrId_CCTransactions");
               });

               modelBuilder.Entity<ContactMechanism>(entity =>
               {
                    entity.HasNoKey();

                    entity.Property(e => e.ContMechId)
                     .ValueGeneratedOnAdd()
                     .HasColumnName("ContMechID");

                    entity.Property(e => e.Email)
                     .HasMaxLength(25)
                     .IsUnicode(false);

                    entity.Property(e => e.Phone)
                     .HasMaxLength(25)
                     .IsUnicode(false);

                    entity.Property(e => e.SiteUrl)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ValidUntil)
                     .HasColumnType("date")
                     .HasDefaultValueSql("(dateadd(year,(20),getdate()))");

                    entity.HasOne(d => d.Address)
                     .WithMany()
                     .HasForeignKey(d => d.AddressId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_EntityAddress_EntityAddress");

                    entity.HasOne(d => d.ContactType)
                     .WithMany()
                     .HasForeignKey(d => d.ContactTypeId)
                     .HasConstraintName("FK_ContactTypeId");

                    entity.HasOne(d => d.Entity)
                     .WithMany()
                     .HasForeignKey(d => d.EntityId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_EntityAddress_Entity");
               });

               modelBuilder.Entity<ContactType>(entity =>
               {
                    entity.ToTable("ContactType");

                    entity.Property(e => e.ContactTypeName)
                     .HasMaxLength(20)
                     .IsUnicode(false);
               });

               //modelBuilder.Entity<Entity>(entity =>
               //{
               //    entity.ToTable("Entity");

               //    entity.HasOne(d => d.Location)
               //        .WithMany(p => p.Entities)
               //        .HasForeignKey(d => d.LocationId)
               //        .HasConstraintName("FK_LocationId_Locations");
               //});

               modelBuilder.Entity<EntityType>(entity =>
               {
                    entity.ToTable("EntityType");

                    entity.Property(e => e.Name)
                     .IsRequired()
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<GeoCity>(entity =>
               {
                    entity.HasKey(e => e.CityId)
                     .HasName("PK__GeoCity__F2D21B765FD9353C");

                    entity.ToTable("GeoCity");

                    entity.Property(e => e.CityName)
                     .HasMaxLength(25)
                     .IsUnicode(false);

                    entity.Property(e => e.Iatacode)
                     .HasMaxLength(3)
                     .IsUnicode(false)
                     .HasColumnName("IATACode");

                    entity.Property(e => e.NationId).HasColumnName("NationID");

                 //entity.HasOne(d => d.Nation)
                 //    .WithMany(p => p.GeoCities)
                 //    .HasForeignKey(d => d.NationId)
                 //    .HasConstraintName("FK_NationId");
            });

               modelBuilder.Entity<GeoNation>(entity =>
               {
                    entity.HasKey(e => e.NationId)
                     .HasName("PK__GeoNatio__211B9BDE6CFD39AF");

                    entity.Property(e => e.NationId).HasColumnName("NationID");

                    entity.Property(e => e.Isocode)
                     .HasMaxLength(2)
                     .IsUnicode(false)
                     .HasColumnName("ISOCode");

                    entity.Property(e => e.NationName)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<GeoRegion>(entity =>
               {
                    entity.HasKey(e => e.RegionId)
                     .HasName("PK__GeoRegio__ACD844A3E7144941");

                    entity.Property(e => e.RegionName)
                     .HasMaxLength(20)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<Location>(entity =>
               {
                    entity.Property(e => e.LocationName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                 //entity.HasOne(d => d.LocationType)
                 //    .WithMany(p => p.Locations)
                 //    .HasForeignKey(d => d.LocationTypeId)
                 //    .OnDelete(DeleteBehavior.ClientSetNull)
                 //    .HasConstraintName("FK_Location_LocationType");
            });

               modelBuilder.Entity<LocationsType>(entity =>
               {
                    entity.HasKey(e => e.LocTypeId);

                    entity.ToTable("LocationsType");

                    entity.Property(e => e.LocTypeName)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<Order>(entity =>
               {
                    entity.HasKey(e => e.OrdersId)
                     .HasName("PK__Orders__630B99767E2AD009");

                    entity.Property(e => e.Delivered).HasColumnType("datetime");

                    entity.Property(e => e.Shipped).HasColumnType("datetime");

                    entity.HasOne(d => d.OrdersHdr)
                     .WithMany(p => p.Orders)
                     .HasForeignKey(d => d.OrdersHdrId)
                     .HasConstraintName("FK_OrdersHdrId_Orders ");

                 //entity.HasOne(d => d.Service)
                 //    .WithMany(p => p.Orders)
                 //    .HasForeignKey(d => d.ServiceId)
                 //    .HasConstraintName("FK_ServiceId_Orders ");

                 //entity.HasOne(d => d.State)
                 //    .WithMany(p => p.Orders)
                 //    .HasForeignKey(d => d.StateId)
                 //    .HasConstraintName("FK_Orders_StateId");
            });

               modelBuilder.Entity<OrdersHeader>(entity =>
               {
                    entity.HasKey(e => e.OrdersHdrId)
                     .HasName("PK__OrdersHe__21388ADAD80E24CC");

                    entity.ToTable("OrdersHeader");

                    entity.Property(e => e.Delivered).HasColumnType("datetime");

                    entity.Property(e => e.OrderDate).HasColumnType("datetime");

                    entity.Property(e => e.Shipped).HasColumnType("datetime");

                 //entity.HasOne(d => d.Entity)
                 //    .WithMany(p => p.OrdersHeaders)
                 //    .HasForeignKey(d => d.EntityId)
                 //    .HasConstraintName("FK_OrdersHeader_EntityId");

                 //entity.HasOne(d => d.State)
                 //    .WithMany(p => p.OrdersHeaders)
                 //    .HasForeignKey(d => d.StateId)
                 //    .HasConstraintName("FK_OrdersHeader_StateId");
            });

               modelBuilder.Entity<PaymentHist>(entity =>
               {
                    entity.HasKey(e => e.PaymentsId).HasName("PK__PaymentH__FD75744A996DEA4C");

                    entity.ToTable("PaymentHist");

                    entity.Property(e => e.Amount).HasColumnType("money");

                    entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                    entity.HasOne(d => d.OrdersHdr)
                        .WithMany(p => p.PaymentHist)
                        .HasForeignKey(d => d.OrdersHdrId)
                        .HasConstraintName("OrdersHdrId_IN_PaymentHist");

                    entity.HasOne(d => d.PaymntState)
                        .WithMany(p => p.PaymentHist)
                        .HasForeignKey(d => d.PaymntStateId)
                        .HasConstraintName("FK_PaymntStateId_PaymentHist");
               });

               modelBuilder.Entity<Person>(entity =>
               {
                    entity.Property(e => e.LastName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.PersonName)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<PersonsRole>(entity =>
               {
                    entity.HasKey(e => e.PersonRolesId);

                    entity.Property(e => e.RoleId).HasDefaultValueSql("((1))");

                 //entity.HasOne(d => d.Person)
                 //    .WithMany(p => p.PersonsRoles)
                 //    .HasForeignKey(d => d.PersonId)
                 //    .OnDelete(DeleteBehavior.ClientSetNull)
                 //    .HasConstraintName("FK_PersonRoles_Person");

                 //entity.HasOne(d => d.Role)
                 //    .WithMany(p => p.PersonsRoles)
                 //    .HasForeignKey(d => d.RoleId)
                 //    .OnDelete(DeleteBehavior.ClientSetNull)
                 //    .HasConstraintName("FK_PersonRoles_Roles");
            });

               modelBuilder.Entity<PriceList>(entity =>
               {
                    entity.ToTable("PriceList");

                    entity.Property(e => e.ListName)
                     .IsRequired()
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.Price).HasColumnType("money");

                    entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                    entity.Property(e => e.ValidUntil).HasColumnType("datetime");

                 //entity.HasOne(d => d.Service)
                 //    .WithMany(p => p.PriceLists)
                 //    .HasForeignKey(d => d.ServiceId)
                 //    .OnDelete(DeleteBehavior.ClientSetNull)
                 //    .HasConstraintName("FK_ServiceId");
            });

               modelBuilder.Entity<Promotion>(entity =>
               {
                    entity.HasKey(e => e.PromotionsId)
                     .HasName("PK__Promotio__DBE22B9224F151C4");

                    entity.Property(e => e.PromDescr)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                    entity.Property(e => e.ValidUntil).HasColumnType("datetime");

                 //entity.HasOne(d => d.Service)
                 //    .WithMany(p => p.Promotions)
                 //    .HasForeignKey(d => d.ServiceId)
                 //    .HasConstraintName("FK_ServiceId_for_Promotions");
            });

               modelBuilder.Entity<Property>(entity =>
               {
                    entity.ToTable("Property");

                    entity.Property(e => e.PropertyName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.HasOne(d => d.PropertyType)
                     .WithMany(p => p.Properties)
                     .HasForeignKey(d => d.PropertyTypeId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK_Property_PropertyType");
               });

               modelBuilder.Entity<PropertyType>(entity =>
               {
                    entity.ToTable("PropertyType");

                    entity.Property(e => e.PropTypeName)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<Role>(entity =>
               {
                    entity.Property(e => e.RoleName)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<Service>(entity =>
               {
                    entity.HasKey(e => e.ServicesId)
                     .HasName("PK__Services__BE1AC7233FCC1068");

                    entity.Property(e => e.Requirements)
                     .HasMaxLength(200)
                     .IsUnicode(false);

                    entity.Property(e => e.ServiceDescr)
                     .HasMaxLength(400)
                     .IsUnicode(false);

                    entity.Property(e => e.ServicesName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                 //entity.HasOne(d => d.City)
                 //    .WithMany(p => p.Services)
                 //    .HasForeignKey(d => d.CityId)
                 //    .HasConstraintName("FK_CityId");

                 //entity.HasOne(d => d.DurUom)
                 //    .WithMany(p => p.ServiceDurUoms)
                 //    .HasForeignKey(d => d.DurUomId)
                 //    .HasConstraintName("FK_DurUomId");

                 //entity.HasOne(d => d.Region)
                 //    .WithMany(p => p.Services)
                 //    .HasForeignKey(d => d.RegionId)
                 //    .HasConstraintName("FK_ReagionId");

                 //entity.HasOne(d => d.ServType)
                 //    .WithMany(p => p.Services)
                 //    .HasForeignKey(d => d.ServTypeId)
                 //    .HasConstraintName("FK_ServiceTypeId");

                 //entity.HasOne(d => d.UnitOfMeasure)
                 //    .WithMany(p => p.ServiceUnitOfMeasures)
                 //    .HasForeignKey(d => d.UnitOfMeasureId)
                 //    .HasConstraintName("FK_UnitOfMeasureId");
            });

               modelBuilder.Entity<ServiceMedia>(entity =>
               {
                    entity.HasKey(e => e.ServiceMediaId)
                     .HasName("PK__ServiceM__4C3CE5A5D1E8B71F");

                    entity.Property(e => e.MediaDescr)
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.UrlPath)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                    entity.Property(e => e.ValidUntil).HasColumnType("datetime");

                 //entity.HasOne(d => d.Service)
                 //    .WithMany(p => p.ServiceMedia)
                 //    .HasForeignKey(d => d.ServiceId)
                 //    .HasConstraintName("FK_ServiceId_for_media");
            });

               modelBuilder.Entity<ServiceSched>(entity =>
               {
                    entity.ToTable("ServiceSched");

                    entity.Property(e => e.FromDate).HasColumnType("datetime");

                    entity.Property(e => e.UntilDate).HasColumnType("datetime");

                 //entity.HasOne(d => d.Service)
                 //    .WithMany(p => p.ServiceScheds)
                 //    .HasForeignKey(d => d.ServiceId)
                 //    .HasConstraintName("FK_ServiceId_for_ServiceSched");
            });

               modelBuilder.Entity<ServicesType>(entity =>
               {
                    entity.HasKey(e => e.ServTypeId)
                     .HasName("PK__Services__807416C5E418D962");

                    entity.ToTable("ServicesType");

                    entity.Property(e => e.ServTypeName)
                     .HasMaxLength(20)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<ShoppingCart>(entity =>
               {
                    entity.HasKey(e => e.ShopCartId)
                     .HasName("PK__Shopping__38FE709BAC65F2C0");

                    entity.ToTable("ShoppingCart");

                    entity.Property(e => e.Discount).HasColumnType("money");

                    entity.Property(e => e.ShopDate).HasColumnType("datetime");

                 //entity.HasOne(d => d.Entity)
                 //    .WithMany(p => p.ShoppingCarts)
                 //    .HasForeignKey(d => d.EntityId)
                 //    .HasConstraintName("FK_EntityId");

                 //entity.HasOne(d => d.PriceList)
                 //    .WithMany(p => p.ShoppingCarts)
                 //    .HasForeignKey(d => d.PriceListId)
                 //    .HasConstraintName("FK_PriceId_ShoppintCart");

                 entity.HasOne(d => d.Service)
                     .WithMany(p => p.ShoppingCarts)
                     .HasForeignKey(d => d.ServiceId)
                     .HasConstraintName("FK_ServiceId_From_ShoppingCart");

                 //entity.HasOne(d => d.State)
                 //    .WithMany(p => p.ShoppingCarts)
                 //    .HasForeignKey(d => d.StateId)
                 //    .HasConstraintName("FK_ShoppintCart_StateId");
            });

               modelBuilder.Entity<State>(entity =>
               {
                    entity.Property(e => e.StateId).ValueGeneratedNever();

                    entity.Property(e => e.StateCode)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.StateName)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<TransactState>(entity =>
               {
                    entity.HasKey(e => e.StateId)
                     .HasName("PK__Transact__C3BA3B3AFEECBBE7");

                    entity.Property(e => e.StateCode)
                     .HasMaxLength(3)
                     .IsUnicode(false);

                    entity.Property(e => e.StateName)
                     .HasMaxLength(20)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<UnitOfMeasure>(entity =>
               {
                    entity.HasKey(e => e.UoMid)
                     .HasName("PK__UnitOfMe__8286E9DCDE8C6A57");

                    entity.Property(e => e.UoMid).HasColumnName("UoMId");

                    entity.Property(e => e.UomName)
                     .HasMaxLength(15)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<VAddress>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("vAddresses");

                    entity.Property(e => e.Address1)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.Address2)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.City)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.County)
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.StateCode)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.StateName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ZipCode)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<VAddressForAllEntity>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("vAddressForAllEntities");

                    entity.Property(e => e.Address1)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.Address2)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.City)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ContMechId).HasColumnName("ContMechID");

                    entity.Property(e => e.ContactTypeName)
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.County)
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.StateCode)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.StateName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ValidUntil).HasColumnType("date");

                    entity.Property(e => e.ZipCode)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<VContactMechanismForLocation>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("vContactMechanismForLocations");

                    entity.Property(e => e.Address1)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.Address2)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ContMechId).HasColumnName("ContMechID");

                    entity.Property(e => e.ContactTypeName)
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.Email)
                     .HasMaxLength(25)
                     .IsUnicode(false);

                    entity.Property(e => e.LocTypeName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.LocationName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.Phone)
                     .HasMaxLength(25)
                     .IsUnicode(false);

                    entity.Property(e => e.SiteUrl)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.StateCode)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.StateName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ValidUntil).HasColumnType("date");

                    entity.Property(e => e.ZipCode)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<VEntity>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("vEntities");

                    entity.Property(e => e.LastName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.LocTypeName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.LocationName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.PersonName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.RoleName)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<VOrderHeader>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("vOrderHeader");

                    entity.Property(e => e.LastName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.OrderDate).HasColumnType("datetime");

                    entity.Property(e => e.PersonName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.StateName)
                     .HasMaxLength(20)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<VOrdersDetail>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("vOrdersDetails");

                    entity.Property(e => e.Delivered).HasColumnType("datetime");

                    entity.Property(e => e.LastName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.OrderDate).HasColumnType("datetime");

                    entity.Property(e => e.PersonName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.Requirements)
                     .HasMaxLength(200)
                     .IsUnicode(false);

                    entity.Property(e => e.ServicesName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.Shipped).HasColumnType("datetime");
               });

               modelBuilder.Entity<VPersonContactMechnaism>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("vPersonContactMechnaisms");

                    entity.Property(e => e.Address1)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.Address2)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.City)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ContactTypeName)
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.County)
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.Email)
                     .HasMaxLength(25)
                     .IsUnicode(false);

                    entity.Property(e => e.LastName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.PersonName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.Phone)
                     .HasMaxLength(25)
                     .IsUnicode(false);

                    entity.Property(e => e.RoleName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.SiteUrl)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.StateCode)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.StateName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ValidUntil).HasColumnType("date");

                    entity.Property(e => e.ZipCode)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<VPersonsRole>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("vPersonsRoles");

                    entity.Property(e => e.LastName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.PersonName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.RoleName)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<VPropertiesContactMechanism>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("vPropertiesContactMechanisms");

                    entity.Property(e => e.Address1)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.Address2)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.City)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ContactTypeName)
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.County)
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.Email)
                     .HasMaxLength(25)
                     .IsUnicode(false);

                    entity.Property(e => e.Phone)
                     .HasMaxLength(25)
                     .IsUnicode(false);

                    entity.Property(e => e.PropTypeName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.PropertyName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.SiteUrl)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.StateCode)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.StateName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ValidUntil).HasColumnType("date");

                    entity.Property(e => e.ZipCode)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<VProperty>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("vProperties");

                    entity.Property(e => e.PropertyName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.PropertyType)
                     .HasMaxLength(50)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<VService>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("vServices");

                    entity.Property(e => e.CityName)
                     .HasMaxLength(25)
                     .IsUnicode(false);

                    entity.Property(e => e.Expr1)
                     .HasMaxLength(15)
                     .IsUnicode(false);

                    entity.Property(e => e.RegionName)
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.Requirements)
                     .HasMaxLength(200)
                     .IsUnicode(false);

                    entity.Property(e => e.ServTypeName)
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.ServiceDescr)
                     .HasMaxLength(400)
                     .IsUnicode(false);

                    entity.Property(e => e.ServicesName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.UomName)
                     .HasMaxLength(15)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<View1>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("View_1");

                    entity.Property(e => e.LastName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ListName)
                     .IsRequired()
                     .HasMaxLength(20)
                     .IsUnicode(false);

                    entity.Property(e => e.PersonName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.Price).HasColumnType("money");

                    entity.Property(e => e.ServicesName)
                     .HasMaxLength(50)
                     .IsUnicode(false);

                    entity.Property(e => e.ShopDate).HasColumnType("datetime");

                    entity.Property(e => e.StateName)
                     .HasMaxLength(20)
                     .IsUnicode(false);
               });

               modelBuilder.Entity<View2>(entity =>
               {
                    entity.HasNoKey();

                    entity.ToView("View_2");

                    entity.Property(e => e.Amount).HasColumnType("money");

                    entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                    entity.Property(e => e.StateCode)
                     .HasMaxLength(3)
                     .IsUnicode(false);

                    entity.Property(e => e.StateName)
                     .HasMaxLength(20)
                     .IsUnicode(false);
               });

               OnModelCreatingPartial(modelBuilder);
          }

          partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
     }
}
