using Develover.Core.Entities;
using Develover.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Develover.Core
{
    public class DeveloverDbContext : DbContext, IDbContext
    {
        #region Ctor

        public DeveloverDbContext()
               : base($@"Server = {DeveloverOptions.InfoDatabase.ServerName}; User Id = {DeveloverOptions.InfoDatabase.UsernameSQL}; Password = {DeveloverOptions.InfoDatabase.PasswordSQL};")
        {
            //((IObjectContextAdapter) this).ObjectContext.ContextOptions.LazyLoadingEnabled = true;
            Database.SetInitializer<DeveloverDbContext>(null);
        }

        #endregion
        #region DataSetModel
        public virtual DbSet<Account> SysDELListVoucher { get; set; }
        public virtual DbSet<AccountObject> AccountObjects { get; set; }
        public virtual DbSet<AccountObjectBankAccount> AccountObjectBankAccounts { get; set; }
        public virtual DbSet<AccountObjectGroup> AccountObjectGroups { get; set; }
        public virtual DbSet<AccountTransfer> AccountTransfers { get; set; }
        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchType> BranchTypes { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<DeliveryDetail> DeliveryDetails { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product1> Product1 { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<SchedulerAppointment> SchedulerAppointments { get; set; }
        public virtual DbSet<SchedulerResource> SchedulerResources { get; set; }
        public virtual DbSet<SchedulerTaskDependency> SchedulerTaskDependencies { get; set; }
        public virtual DbSet<sysDELGridColumn> sysDELGridColumns { get; set; }
        public virtual DbSet<sysDELGroupUser> sysDELGroupUsers { get; set; }
        public virtual DbSet<SysDELHistoryLogin> SysDELHistoryLogins { get; set; }
        public virtual DbSet<SysDELListVoucher> SysDELListVouchers { get; set; }
        public virtual DbSet<sysDELOption> sysDELOptions { get; set; }
        public virtual DbSet<sysDELUser> sysDELUsers { get; set; }
        public virtual DbSet<UOM> UOMs { get; set; }
        public virtual DbSet<Vender> Venders { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<AccountHistory> AccountHistories { get; set; }
        public virtual DbSet<AccountObjectBankAccountHistory> AccountObjectBankAccountHistories { get; set; }
        public virtual DbSet<AccountObjectGroupHistory> AccountObjectGroupHistories { get; set; }
        public virtual DbSet<AccountObjectHistory> AccountObjectHistories { get; set; }
        public virtual DbSet<AccountTransferHistory> AccountTransferHistories { get; set; }
        public virtual DbSet<BADeposit> BADeposits { get; set; }
        public virtual DbSet<BADepositDetail> BADepositDetails { get; set; }
        public virtual DbSet<BankAccountHistory> BankAccountHistories { get; set; }
        public virtual DbSet<BAWithDraw> BAWithDraws { get; set; }
        public virtual DbSet<BAWithDrawDetail> BAWithDrawDetails { get; set; }
        public virtual DbSet<BranchHistory> BranchHistories { get; set; }
        public virtual DbSet<BranchTypeHistory> BranchTypeHistories { get; set; }
        public virtual DbSet<CAPayment> CAPayments { get; set; }
        public virtual DbSet<CAPaymentDetail> CAPaymentDetails { get; set; }
        public virtual DbSet<CAReceipt> CAReceipts { get; set; }
        public virtual DbSet<CAReceiptDetail> CAReceiptDetails { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<grid> grids { get; set; }
        public virtual DbSet<HEADERDELIVERY21C77654CD904F4685515946D5E3ACFC> HEADERDELIVERY21C77654CD904F4685515946D5E3ACFC { get; set; }
        public virtual DbSet<HEADERDELIVERY39668C965069455DAC584186C942B8F1> HEADERDELIVERY39668C965069455DAC584186C942B8F1 { get; set; }
        public virtual DbSet<HEADERDELIVERY52E31404701A47A0A9514573C7BBB3FF> HEADERDELIVERY52E31404701A47A0A9514573C7BBB3FF { get; set; }
        public virtual DbSet<INInward> INInwards { get; set; }
        public virtual DbSet<INInwardDetail> INInwardDetails { get; set; }
        public virtual DbSet<INOutward> INOutwards { get; set; }
        public virtual DbSet<INOutwardDetail> INOutwardDetails { get; set; }
        public virtual DbSet<INTransfer> INTransfers { get; set; }
        public virtual DbSet<INTransferDetail> INTransferDetails { get; set; }
        public virtual DbSet<LocationHistory> LocationHistories { get; set; }
        public virtual DbSet<ProductHistory> ProductHistories { get; set; }
        public virtual DbSet<ProductTypeHistory> ProductTypeHistories { get; set; }
        public virtual DbSet<PUReturn> PUReturns { get; set; }
        public virtual DbSet<PUReturnDetail> PUReturnDetails { get; set; }
        public virtual DbSet<PUVoucher> PUVouchers { get; set; }
        public virtual DbSet<PUVoucherDetail> PUVoucherDetails { get; set; }
        public virtual DbSet<SAReturn> SAReturns { get; set; }
        public virtual DbSet<SAReturnDetail> SAReturnDetails { get; set; }
        public virtual DbSet<SAVoucher> SAVouchers { get; set; }
        public virtual DbSet<SAVoucherDetail> SAVoucherDetails { get; set; }
        public virtual DbSet<UOMHistory> UOMHistories { get; set; }
        public virtual DbSet<VDelivery> VDeliveries { get; set; }
        public virtual DbSet<VDeliverySearch> VDeliverySearches { get; set; }
        public virtual DbSet<VProduct> VProducts { get; set; }
        public virtual DbSet<VSysDELHistoryLogin> VSysDELHistoryLogins { get; set; }
        #endregion
        #region Utilities

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Attach an entity to the context or return an already attached entity (if it was already attached)
        /// </summary>
        /// <typeparam name="TEntity">TEntity</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>Attached entity</returns>
        protected virtual TEntity AttachEntityToContext<TEntity>(TEntity entity) where TEntity : BaseEntity, new()
        {
            //little hack here until Entity Framework really supports stored procedures
            //otherwise, navigation properties of loaded entities are not loaded until an entity is attached to the context
            var alreadyAttached = Set<TEntity>().Local.FirstOrDefault(x => x.Id == entity.Id);
            if (alreadyAttached == null)
            {
                //attach new entity
                Set<TEntity>().Attach(entity);
                return entity;
            }

            //entity is already loaded
            return alreadyAttached;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Create database script
        /// </summary>
        /// <returns>SQL to generate database</returns>
        public string CreateDatabaseScript()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateDatabaseScript();
        }

        /// <summary>
        /// Get DbSet
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>DbSet</returns>
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        /// <summary>
        /// Execute stores procedure and load a list of entities at the end
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="commandText">Command text</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>Entities</returns>
        public IList<TEntity> ExecuteStoredProcedureList<TEntity>(string commandText, params object[] parameters) where TEntity : BaseEntity, new()
        {
            //add parameters to command
            if (parameters != null && parameters.Length > 0)
            {
                for (int i = 0; i <= parameters.Length - 1; i++)
                {
                    if (!(parameters[i] is DbParameter p))
                        throw new Exception("Not support parameter type");

                    commandText += i == 0 ? " " : ", ";

                    commandText += "@" + p.ParameterName;
                    if (p.Direction == ParameterDirection.InputOutput || p.Direction == ParameterDirection.Output)
                    {
                        //output parameter
                        commandText += " output";
                    }
                }
            }

            var result = this.Database.SqlQuery<TEntity>(commandText, parameters).ToList();

            bool acd = this.Configuration.AutoDetectChangesEnabled;
            try
            {
                this.Configuration.AutoDetectChangesEnabled = false;

                for (int i = 0; i < result.Count; i++)
                    result[i] = AttachEntityToContext(result[i]);
            }
            finally
            {
                this.Configuration.AutoDetectChangesEnabled = acd;
            }

            return result;
        }

        /// <summary>
        /// Creates a raw SQL query that will return elements of the given generic type.  The type can be any type that has properties that match the names of the columns returned from the query, or can be a simple primitive type. The type does not have to be an entity type. The results of this query are never tracked by the context even if the type of object returned is an entity type.
        /// </summary>
        /// <typeparam name="TElement">The type of object returned by the query.</typeparam>
        /// <param name="sql">The SQL query string.</param>
        /// <param name="parameters">The parameters to apply to the SQL query string.</param>
        /// <returns>Result</returns>
        public IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters)
        {
            return this.Database.SqlQuery<TElement>(sql, parameters);
        }

        /// <summary>
        /// Executes the given DDL/DML command against the database.
        /// </summary>
        /// <param name="sql">The command string</param>
        /// <param name="doNotEnsureTransaction">false - the transaction creation is not ensured; true - the transaction creation is ensured.</param>
        /// <param name="timeout">Timeout value, in seconds. A null value indicates that the default value of the underlying provider will be used</param>
        /// <param name="parameters">The parameters to apply to the command string.</param>
        /// <returns>The result returned by the database after executing the command.</returns>
        public int ExecuteSqlCommand(string sql, bool doNotEnsureTransaction = false, int? timeout = null, params object[] parameters)
        {
            int? previousTimeout = null;
            if (timeout.HasValue)
            {
                //store previous timeout
                previousTimeout = ((IObjectContextAdapter)this).ObjectContext.CommandTimeout;
                ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = timeout;
            }

            var transactionalBehavior = doNotEnsureTransaction
                ? TransactionalBehavior.DoNotEnsureTransaction
                : TransactionalBehavior.EnsureTransaction;
            var result = this.Database.ExecuteSqlCommand(transactionalBehavior, sql, parameters);

            if (timeout.HasValue)
            {
                //Set previous timeout back
                ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = previousTimeout;
            }

            //return result
            return result;
        }

        #endregion
    }
}
