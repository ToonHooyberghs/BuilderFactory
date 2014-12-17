
        using System;
using System.Data;
using System.Reflection;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SDWORX.Rapportering.Essence.Interfaces.Enums;
using SDWORX.Rapportering.Essence.Domain.Web.Common;
using SDWORX.Rapportering.Essence.Domain.Web.Waarden;
using SDWORX.Rapportering.Essence.Domain.Web.Folders;
using SDWORX.Rapportering.Essence.Domain.Web.Prompts;
using SDWORX.Rapportering.Essence.Domain.Web.Metadata;
using SDWORX.Rapportering.Essence.Interfaces.Metadata;
using SDWORX.Rapportering.Essence.Domain.Web.Selecties;
using SDWORX.Rapportering.Essence.Domain.Web.Rubrieken;
using SDWORX.Rapportering.Essence.Interfaces.Selecties;
using SDWORX.Rapportering.Essence.Domain.Web.Parameters;
using SDWORX.Rapportering.Essence.Domain.Web.Bewerkingen;
using SDWORX.Rapportering.Essence.Domain.Web.Rapportering;
using SDWORX.Rapportering.Essence.Interfaces.Rapportering;
using SDWORX.Rapportering.Essence.Domain.Web.GegevensTypes;
using SDWORX.Rapportering.Essence.Domain.Web.RubriekMappingen;

        namespace Entities.Builders
        {
            
        public partial class BewerkingBuilder : BaseBuilder<Bewerking,BewerkingBuilder>
        {

        #region Constructors
        
        public static BewerkingBuilder Init()
        {
              return new BewerkingBuilder();
        }

        public BewerkingBuilder()
        {
              Instance = new Bewerking();            
        }

      


        #endregion

        #region Properties
        
        public BewerkingBuilder Statements(Collection<Statement> value)
        {
            Instance.Statements = value;
            return this;
        }

      


        public BewerkingBuilder Id(Int32 value)
        {
            Instance.Id = value;
            return this;
        }

      


        public BewerkingBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public BewerkingBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class ConditioneelStatementBuilder : BaseBuilder<ConditioneelStatement,ConditioneelStatementBuilder>
        {

        #region Constructors
        
        public static ConditioneelStatementBuilder Init()
        {
              return new ConditioneelStatementBuilder();
        }

        public ConditioneelStatementBuilder()
        {
              Instance = new ConditioneelStatement();            
        }

      


        #endregion

        #region Properties
        
        public ConditioneelStatementBuilder Selectie(Selectie value)
        {
            Instance.Selectie = value;
            return this;
        }

      


        public ConditioneelStatementBuilder Nummer(Int32 value)
        {
            Instance.Nummer = value;
            return this;
        }

      


        public ConditioneelStatementBuilder Resultaat(Resultaat value)
        {
            Instance.Resultaat = value;
            return this;
        }

      


        public ConditioneelStatementBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public ConditioneelStatementBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public ConditioneelStatementBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class ExpressieBuilder : BaseBuilder<Expressie,ExpressieBuilder>
        {

        #region Constructors
        
        public static ExpressieBuilder Init()
        {
              return new ExpressieBuilder();
        }

        public ExpressieBuilder()
        {
              Instance = new Expressie();            
        }

      


        #endregion

        #region Properties
        
        public ExpressieBuilder Lijnen(Collection<ExpressieLijn> value)
        {
            Instance.Lijnen = value;
            return this;
        }

      


        public ExpressieBuilder Id(Int32 value)
        {
            Instance.Id = value;
            return this;
        }

      


        public ExpressieBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public ExpressieBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class ExpressieLijnBuilder : BaseBuilder<ExpressieLijn,ExpressieLijnBuilder>
        {

        #region Constructors
        
        public static ExpressieLijnBuilder Init()
        {
              return new ExpressieLijnBuilder();
        }

        public ExpressieLijnBuilder()
        {
              Instance = new ExpressieLijn();            
        }

      


        #endregion

        #region Properties
        
        public ExpressieLijnBuilder EersteOperator(String value)
        {
            Instance.EersteOperator = value;
            return this;
        }

      


        public ExpressieLijnBuilder TweedeOperator(String value)
        {
            Instance.TweedeOperator = value;
            return this;
        }

      


        public ExpressieLijnBuilder EersteArgument(Waarde value)
        {
            Instance.EersteArgument = value;
            return this;
        }

      


        public ExpressieLijnBuilder TweedeArgument(Waarde value)
        {
            Instance.TweedeArgument = value;
            return this;
        }

      


        public ExpressieLijnBuilder AantalOpenHaakjes(Int32 value)
        {
            Instance.AantalOpenHaakjes = value;
            return this;
        }

      


        public ExpressieLijnBuilder AantalSluitHaakjes(Int32 value)
        {
            Instance.AantalSluitHaakjes = value;
            return this;
        }

      


        public ExpressieLijnBuilder ParentId(Int32 value)
        {
            Instance.ParentId = value;
            return this;
        }

      


        public ExpressieLijnBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public ExpressieLijnBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class ResultaatBuilder : BaseBuilder<Resultaat,ResultaatBuilder>
        {

        #region Constructors
        
        public static ResultaatBuilder Init()
        {
              return new ResultaatBuilder();
        }

        public ResultaatBuilder()
        {
              Instance = new Resultaat();            
        }

      


        #endregion

        #region Properties
        
        public ResultaatBuilder ResultaatType(ResultaatType value)
        {
            Instance.ResultaatType = value;
            return this;
        }

      


        public ResultaatBuilder TussenResultaatId(Int32 value)
        {
            Instance.TussenResultaatId = value;
            return this;
        }

      


        public ResultaatBuilder LogischGegevensType(LogischGegevensType value)
        {
            Instance.LogischGegevensType = value;
            return this;
        }

      


        public ResultaatBuilder Nummer(Int32 value)
        {
            Instance.Nummer = value;
            return this;
        }

      


        public ResultaatBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public ResultaatBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class ToekenningStatementBuilder : BaseBuilder<ToekenningStatement,ToekenningStatementBuilder>
        {

        #region Constructors
        
        public static ToekenningStatementBuilder Init()
        {
              return new ToekenningStatementBuilder();
        }

        public ToekenningStatementBuilder()
        {
              Instance = new ToekenningStatement();            
        }

      


        #endregion

        #region Properties
        
        public ToekenningStatementBuilder Expressie(Expressie value)
        {
            Instance.Expressie = value;
            return this;
        }

      


        public ToekenningStatementBuilder WaarCondities(IList<Int32> value)
        {
            Instance.WaarCondities = value;
            return this;
        }

      


        public ToekenningStatementBuilder OnwaarCondities(IList<Int32> value)
        {
            Instance.OnwaarCondities = value;
            return this;
        }

      


        public ToekenningStatementBuilder Nummer(Int32 value)
        {
            Instance.Nummer = value;
            return this;
        }

      


        public ToekenningStatementBuilder Resultaat(Resultaat value)
        {
            Instance.Resultaat = value;
            return this;
        }

      


        public ToekenningStatementBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public ToekenningStatementBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public ToekenningStatementBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class ConcernInfoBuilder : BaseBuilder<ConcernInfo,ConcernInfoBuilder>
        {

        #region Constructors
        
        public static ConcernInfoBuilder Init()
        {
              return new ConcernInfoBuilder();
        }

        public ConcernInfoBuilder()
        {
              Instance = new ConcernInfo();            
        }

      


        #endregion

        #region Properties
        
        public ConcernInfoBuilder OrganisatieOSL(String value)
        {
            Instance.OrganisatieOSL = value;
            return this;
        }

      


        public ConcernInfoBuilder OrganisatieId(Int32 value)
        {
            Instance.OrganisatieId = value;
            return this;
        }

      


        public ConcernInfoBuilder OndersteundeTalen(Collection<String> value)
        {
            Instance.OndersteundeTalen = value;
            return this;
        }

      


        public ConcernInfoBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public ConcernInfoBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class OmschrijvingBuilder : BaseBuilder<Omschrijving,OmschrijvingBuilder>
        {

        #region Constructors
        
        public static OmschrijvingBuilder Init()
        {
              return new OmschrijvingBuilder();
        }

        public OmschrijvingBuilder()
        {
              Instance = new Omschrijving();            
        }

      


        public static OmschrijvingBuilder Init(String taal , String tekst)
        {
              return new OmschrijvingBuilder(taal , tekst);
        }

        public OmschrijvingBuilder(String taal , String tekst)
        {
              Instance = new Omschrijving(taal , tekst);            
        }

      


        #endregion

        #region Properties
        
        public OmschrijvingBuilder Tekst(String value)
        {
            Instance.Tekst = value;
            return this;
        }

      


        public OmschrijvingBuilder LangeOmschrijving(String value)
        {
            Instance.LangeOmschrijving = value;
            return this;
        }

      


        public OmschrijvingBuilder Taal(String value)
        {
            Instance.Taal = value;
            return this;
        }

      


        public OmschrijvingBuilder ParentId(Int32 value)
        {
            Instance.ParentId = value;
            return this;
        }

      


        public OmschrijvingBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public OmschrijvingBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class RapportFolderBuilder : BaseBuilder<RapportFolder,RapportFolderBuilder>
        {

        #region Constructors
        
        public static RapportFolderBuilder Init()
        {
              return new RapportFolderBuilder();
        }

        public RapportFolderBuilder()
        {
              Instance = new RapportFolder();            
        }

      


        #endregion

        #region Properties
        
        public RapportFolderBuilder Intern(Boolean value)
        {
            Instance.Intern = value;
            return this;
        }

      


        public RapportFolderBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public RapportFolderBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class GegevensTypeInfoBuilder : BaseBuilder<GegevensTypeInfo,GegevensTypeInfoBuilder>
        {

        #region Constructors
        
        public static GegevensTypeInfoBuilder Init()
        {
              return new GegevensTypeInfoBuilder();
        }

        public GegevensTypeInfoBuilder()
        {
              Instance = new GegevensTypeInfo();            
        }

      


        #endregion

        #region Properties
        
        public GegevensTypeInfoBuilder ParameterCode(String value)
        {
            Instance.ParameterCode = value;
            return this;
        }

      


        public GegevensTypeInfoBuilder LogischGegevensType(LogischGegevensType value)
        {
            Instance.LogischGegevensType = value;
            return this;
        }

      


        public GegevensTypeInfoBuilder LogischeEenheidsCode(String value)
        {
            Instance.LogischeEenheidsCode = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class FysischeTabelBuilder : BaseBuilder<FysischeTabel,FysischeTabelBuilder>
        {

        #region Constructors
        
        public static FysischeTabelBuilder Init()
        {
              return new FysischeTabelBuilder();
        }

        public FysischeTabelBuilder()
        {
              Instance = new FysischeTabel();            
        }

      


        #endregion

        #region Properties
        
        public FysischeTabelBuilder TabelNaam(String value)
        {
            Instance.TabelNaam = value;
            return this;
        }

      


        public FysischeTabelBuilder BeginDatumKolomNaam(String value)
        {
            Instance.BeginDatumKolomNaam = value;
            return this;
        }

      


        public FysischeTabelBuilder EindDatumKolomNaam(String value)
        {
            Instance.EindDatumKolomNaam = value;
            return this;
        }

      


        public FysischeTabelBuilder Referentie(String value)
        {
            Instance.Referentie = value;
            return this;
        }

      


        public FysischeTabelBuilder IsHistorisch(Boolean value)
        {
            Instance.IsHistorisch = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class GenesteTabelExpressieBuilder : BaseBuilder<GenesteTabelExpressie,GenesteTabelExpressieBuilder>
        {

        #region Constructors
        
        public static GenesteTabelExpressieBuilder Init(String tabelExpressie)
        {
              return new GenesteTabelExpressieBuilder(tabelExpressie);
        }

        public GenesteTabelExpressieBuilder(String tabelExpressie)
        {
              Instance = new GenesteTabelExpressie(tabelExpressie);            
        }

      


        #endregion

        #region Properties
        
        public GenesteTabelExpressieBuilder Referentie(String value)
        {
            Instance.Referentie = value;
            return this;
        }

      


        public GenesteTabelExpressieBuilder BeginDatumKolomNaam(String value)
        {
            Instance.BeginDatumKolomNaam = value;
            return this;
        }

      


        public GenesteTabelExpressieBuilder EindDatumKolomNaam(String value)
        {
            Instance.EindDatumKolomNaam = value;
            return this;
        }

      


        public GenesteTabelExpressieBuilder IsHistorisch(Boolean value)
        {
            Instance.IsHistorisch = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class JoinStatementBuilder : BaseBuilder<JoinStatement,JoinStatementBuilder>
        {

        #region Constructors
        
        public static JoinStatementBuilder Init()
        {
              return new JoinStatementBuilder();
        }

        public JoinStatementBuilder()
        {
              Instance = new JoinStatement();            
        }

      


        #endregion

        #region Properties
        
        public JoinStatementBuilder Statement(String value)
        {
            Instance.Statement = value;
            return this;
        }

      


        public JoinStatementBuilder IsVerplicht(Boolean value)
        {
            Instance.IsVerplicht = value;
            return this;
        }

      


        public JoinStatementBuilder AfhankelijkeTabelAlias(TabelAlias value)
        {
            Instance.AfhankelijkeTabelAlias = value;
            return this;
        }

      


        public JoinStatementBuilder JoinType(JoinStatementType value)
        {
            Instance.JoinType = value;
            return this;
        }

      


        public JoinStatementBuilder Id(Int32 value)
        {
            Instance.Id = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class MetaDataBuilder : BaseBuilder<MetaData,MetaDataBuilder>
        {

        #region Constructors
        
        public static MetaDataBuilder Init()
        {
              return new MetaDataBuilder();
        }

        public MetaDataBuilder()
        {
              Instance = new MetaData();            
        }

      


        #endregion

        #region Properties
        
        public MetaDataBuilder RubriekDefinitie(RubriekDefinitie value)
        {
            Instance.RubriekDefinitie = value;
            return this;
        }

      


        public MetaDataBuilder TabelAlias(TabelAlias value)
        {
            Instance.TabelAlias = value;
            return this;
        }

      


        public MetaDataBuilder Id(Int32 value)
        {
            Instance.Id = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class SterschemaRubriekInfoBuilder : BaseBuilder<SterschemaRubriekInfo,SterschemaRubriekInfoBuilder>
        {

        #region Constructors
        
        public static SterschemaRubriekInfoBuilder Init()
        {
              return new SterschemaRubriekInfoBuilder();
        }

        public SterschemaRubriekInfoBuilder()
        {
              Instance = new SterschemaRubriekInfo();            
        }

      


        #endregion

        #region Properties
        
        public SterschemaRubriekInfoBuilder Alias(String value)
        {
            Instance.Alias = value;
            return this;
        }

      


        public SterschemaRubriekInfoBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public SterschemaRubriekInfoBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class TabelAliasBuilder : BaseBuilder<TabelAlias,TabelAliasBuilder>
        {

        #region Constructors
        
        public static TabelAliasBuilder Init()
        {
              return new TabelAliasBuilder();
        }

        public TabelAliasBuilder()
        {
              Instance = new TabelAlias();            
        }

      


        #endregion

        #region Properties
        
        public TabelAliasBuilder BasedOn(TabelAlias value)
        {
            Instance.BasedOn = value;
            return this;
        }

      


        public TabelAliasBuilder DerivedBy(Collection<TabelAlias> value)
        {
            Instance.DerivedBy = value;
            return this;
        }

      


        public TabelAliasBuilder CalledFrom(TabelAlias value)
        {
            Instance.CalledFrom = value;
            return this;
        }

      


        public TabelAliasBuilder AliasNaam(String value)
        {
            Instance.AliasNaam = value;
            return this;
        }

      


        public TabelAliasBuilder OrigineleAliasNaam(String value)
        {
            Instance.OrigineleAliasNaam = value;
            return this;
        }

      


        public TabelAliasBuilder AlternateAliasNaam(String value)
        {
            Instance.AlternateAliasNaam = value;
            return this;
        }

      


        public TabelAliasBuilder JoinStatements(Collection<JoinStatement> value)
        {
            Instance.JoinStatements = value;
            return this;
        }

      


        public TabelAliasBuilder TabelReferentie(ITabelReferentie value)
        {
            Instance.TabelReferentie = value;
            return this;
        }

      


        public TabelAliasBuilder Constraint(String value)
        {
            Instance.Constraint = value;
            return this;
        }

      


        public TabelAliasBuilder Id(Int32 value)
        {
            Instance.Id = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class KlantParameterInfoBuilder : BaseBuilder<KlantParameterInfo,KlantParameterInfoBuilder>
        {

        #region Constructors
        
        public static KlantParameterInfoBuilder Init()
        {
              return new KlantParameterInfoBuilder();
        }

        public KlantParameterInfoBuilder()
        {
              Instance = new KlantParameterInfo();            
        }

      


        #endregion

        #region Properties
        
        public KlantParameterInfoBuilder Code(String value)
        {
            Instance.Code = value;
            return this;
        }

      


        public KlantParameterInfoBuilder RubriekDefinitieID(Int32 value)
        {
            Instance.RubriekDefinitieID = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class PromptDefinitieBuilder : BaseBuilder<PromptDefinitie,PromptDefinitieBuilder>
        {

        #region Constructors
        
        public static PromptDefinitieBuilder Init()
        {
              return new PromptDefinitieBuilder();
        }

        public PromptDefinitieBuilder()
        {
              Instance = new PromptDefinitie();            
        }

      


        #endregion

        #region Properties
        
        public PromptDefinitieBuilder Id(Int32 value)
        {
            Instance.Id = value;
            return this;
        }

      


        public PromptDefinitieBuilder OSL(String value)
        {
            Instance.OSL = value;
            return this;
        }

      


        public PromptDefinitieBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public PromptDefinitieBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class PromptSetBuilder : BaseBuilder<PromptSet,PromptSetBuilder>
        {

        #region Constructors
        
        public static PromptSetBuilder Init()
        {
              return new PromptSetBuilder();
        }

        public PromptSetBuilder()
        {
              Instance = new PromptSet();            
        }

      


        #endregion

        #region Properties
        
        public PromptSetBuilder PromptSetWaarden(Collection<PromptSetItem> value)
        {
            Instance.PromptSetWaarden = value;
            return this;
        }

      


        public PromptSetBuilder Id(Int32 value)
        {
            Instance.Id = value;
            return this;
        }

      


        public PromptSetBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public PromptSetBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class PromptSetItemBuilder : BaseBuilder<PromptSetItem,PromptSetItemBuilder>
        {

        #region Constructors
        
        public static PromptSetItemBuilder Init()
        {
              return new PromptSetItemBuilder();
        }

        public PromptSetItemBuilder()
        {
              Instance = new PromptSetItem();            
        }

      


        #endregion

        #region Properties
        
        public PromptSetItemBuilder Waarde(Waarde value)
        {
            Instance.Waarde = value;
            return this;
        }

      


        public PromptSetItemBuilder Definitie(PromptDefinitie value)
        {
            Instance.Definitie = value;
            return this;
        }

      


        public PromptSetItemBuilder ParentId(Int32 value)
        {
            Instance.ParentId = value;
            return this;
        }

      


        public PromptSetItemBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public PromptSetItemBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class FunctieRapportVeldBuilder : BaseBuilder<FunctieRapportVeld,FunctieRapportVeldBuilder>
        {

        #region Constructors
        
        public static FunctieRapportVeldBuilder Init()
        {
              return new FunctieRapportVeldBuilder();
        }

        public FunctieRapportVeldBuilder()
        {
              Instance = new FunctieRapportVeld();            
        }

      


        #endregion

        #region Properties
        
        public FunctieRapportVeldBuilder MetaDataWaarde(IMetaDataWaarde value)
        {
            Instance.MetaDataWaarde = value;
            return this;
        }

      


        public FunctieRapportVeldBuilder ParameterVoorstelling(ParameterVoorstelling value)
        {
            Instance.ParameterVoorstelling = value;
            return this;
        }

      


        public FunctieRapportVeldBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public FunctieRapportVeldBuilder Omschrijvingen(Collection<Omschrijving> value)
        {
            Instance.Omschrijvingen = value;
            return this;
        }

      


        public FunctieRapportVeldBuilder ClusterID(Nullable<Int32> value)
        {
            Instance.ClusterID = value;
            return this;
        }

      


        public FunctieRapportVeldBuilder ClusterBoomCode(String value)
        {
            Instance.ClusterBoomCode = value;
            return this;
        }

      


        public FunctieRapportVeldBuilder Waarde(FunctieWaarde value)
        {
            Instance.Waarde = value;
            return this;
        }

      


        public FunctieRapportVeldBuilder Kenmerken(RapportVeldKenmerken value)
        {
            Instance.Kenmerken = value;
            return this;
        }

      


        public FunctieRapportVeldBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public FunctieRapportVeldBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class GenerateSqlFromRapportResultaatBuilder : BaseBuilder<GenerateSqlFromRapportResultaat,GenerateSqlFromRapportResultaatBuilder>
        {

        #region Constructors
        
        public static GenerateSqlFromRapportResultaatBuilder Init()
        {
              return new GenerateSqlFromRapportResultaatBuilder();
        }

        public GenerateSqlFromRapportResultaatBuilder()
        {
              Instance = new GenerateSqlFromRapportResultaat();            
        }

      


        #endregion

        #region Properties
        
        public GenerateSqlFromRapportResultaatBuilder RapportKolomInfos(IList<IRapportKolomInfo> value)
        {
            Instance.RapportKolomInfos = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class LogischeDatumRapportVeldBuilder : BaseBuilder<LogischeDatumRapportVeld,LogischeDatumRapportVeldBuilder>
        {

        #region Constructors
        
        public static LogischeDatumRapportVeldBuilder Init()
        {
              return new LogischeDatumRapportVeldBuilder();
        }

        public LogischeDatumRapportVeldBuilder()
        {
              Instance = new LogischeDatumRapportVeld();            
        }

      


        #endregion

        #region Properties
        
        public LogischeDatumRapportVeldBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public LogischeDatumRapportVeldBuilder Omschrijvingen(Collection<Omschrijving> value)
        {
            Instance.Omschrijvingen = value;
            return this;
        }

      


        public LogischeDatumRapportVeldBuilder ClusterID(Nullable<Int32> value)
        {
            Instance.ClusterID = value;
            return this;
        }

      


        public LogischeDatumRapportVeldBuilder ClusterBoomCode(String value)
        {
            Instance.ClusterBoomCode = value;
            return this;
        }

      


        public LogischeDatumRapportVeldBuilder Waarde(SimpeleWaarde value)
        {
            Instance.Waarde = value;
            return this;
        }

      


        public LogischeDatumRapportVeldBuilder Kenmerken(RapportVeldKenmerken value)
        {
            Instance.Kenmerken = value;
            return this;
        }

      


        public LogischeDatumRapportVeldBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public LogischeDatumRapportVeldBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class LoonCodeRangeBuilder : BaseBuilder<LoonCodeRange,LoonCodeRangeBuilder>
        {

        #region Constructors
        
        public static LoonCodeRangeBuilder Init()
        {
              return new LoonCodeRangeBuilder();
        }

        public LoonCodeRangeBuilder()
        {
              Instance = new LoonCodeRange();            
        }

      


        #endregion

        #region Properties
        
        public LoonCodeRangeBuilder Teken(TekenType value)
        {
            Instance.Teken = value;
            return this;
        }

      


        public LoonCodeRangeBuilder Van(String value)
        {
            Instance.Van = value;
            return this;
        }

      


        public LoonCodeRangeBuilder Tot(String value)
        {
            Instance.Tot = value;
            return this;
        }

      


        public LoonCodeRangeBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public LoonCodeRangeBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class PromptDefinitieRapportVeldBuilder : BaseBuilder<PromptDefinitieRapportVeld,PromptDefinitieRapportVeldBuilder>
        {

        #region Constructors
        
        public static PromptDefinitieRapportVeldBuilder Init()
        {
              return new PromptDefinitieRapportVeldBuilder();
        }

        public PromptDefinitieRapportVeldBuilder()
        {
              Instance = new PromptDefinitieRapportVeld();            
        }

      


        #endregion

        #region Properties
        
        public PromptDefinitieRapportVeldBuilder IngevuldeWaarde(Waarde value)
        {
            Instance.IngevuldeWaarde = value;
            return this;
        }

      


        public PromptDefinitieRapportVeldBuilder IsEnabled(Boolean value)
        {
            Instance.IsEnabled = value;
            return this;
        }

      


        public PromptDefinitieRapportVeldBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public PromptDefinitieRapportVeldBuilder Omschrijvingen(Collection<Omschrijving> value)
        {
            Instance.Omschrijvingen = value;
            return this;
        }

      


        public PromptDefinitieRapportVeldBuilder ClusterID(Nullable<Int32> value)
        {
            Instance.ClusterID = value;
            return this;
        }

      


        public PromptDefinitieRapportVeldBuilder ClusterBoomCode(String value)
        {
            Instance.ClusterBoomCode = value;
            return this;
        }

      


        public PromptDefinitieRapportVeldBuilder Waarde(PromptWaarde value)
        {
            Instance.Waarde = value;
            return this;
        }

      


        public PromptDefinitieRapportVeldBuilder Kenmerken(RapportVeldKenmerken value)
        {
            Instance.Kenmerken = value;
            return this;
        }

      


        public PromptDefinitieRapportVeldBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public PromptDefinitieRapportVeldBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class RapportBuilder : BaseBuilder<Rapport,RapportBuilder>
        {

        #region Constructors
        
        public static RapportBuilder Init()
        {
              return new RapportBuilder();
        }

        public RapportBuilder()
        {
              Instance = new Rapport();            
        }

      


        #endregion

        #region Properties
        
        public RapportBuilder RapportVelden(IList<IRapportVeld> value)
        {
            Instance.RapportVelden = value;
            return this;
        }

      


        public RapportBuilder Kenmerken(RapportKenmerken value)
        {
            Instance.Kenmerken = value;
            return this;
        }

      


        public RapportBuilder UitvoerenKenmerken(RapportUitvoerenKenmerken value)
        {
            Instance.UitvoerenKenmerken = value;
            return this;
        }

      


        public RapportBuilder Id(Int32 value)
        {
            Instance.Id = value;
            return this;
        }

      


        public RapportBuilder BewerkingId(Int32 value)
        {
            Instance.BewerkingId = value;
            return this;
        }

      


        public RapportBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public RapportBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class RapportInfoBuilder : BaseBuilder<RapportInfo,RapportInfoBuilder>
        {

        #region Constructors
        
        public static RapportInfoBuilder Init()
        {
              return new RapportInfoBuilder();
        }

        public RapportInfoBuilder()
        {
              Instance = new RapportInfo();            
        }

      


        #endregion

        #region Properties
        
        public RapportInfoBuilder Intern(Boolean value)
        {
            Instance.Intern = value;
            return this;
        }

      


        public RapportInfoBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public RapportInfoBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class RapportKenmerkenBuilder : BaseBuilder<RapportKenmerken,RapportKenmerkenBuilder>
        {

        #region Constructors
        
        public static RapportKenmerkenBuilder Init()
        {
              return new RapportKenmerkenBuilder();
        }

        public RapportKenmerkenBuilder()
        {
              Instance = new RapportKenmerken();            
        }

      


        #endregion

        #region Properties
        
        public RapportKenmerkenBuilder Bewerking(Bewerking value)
        {
            Instance.Bewerking = value;
            return this;
        }

      


        public RapportKenmerkenBuilder Sortering(Collection<Sortering> value)
        {
            Instance.Sortering = value;
            return this;
        }

      


        public RapportKenmerkenBuilder Intern(Boolean value)
        {
            Instance.Intern = value;
            return this;
        }

      


        public RapportKenmerkenBuilder RapportType(RapportType value)
        {
            Instance.RapportType = value;
            return this;
        }

      


        public RapportKenmerkenBuilder ParentId(Int32 value)
        {
            Instance.ParentId = value;
            return this;
        }

      


        public RapportKenmerkenBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public RapportKenmerkenBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class RapportParameterBuilder : BaseBuilder<RapportParameter,RapportParameterBuilder>
        {

        #region Constructors
        
        public static RapportParameterBuilder Init()
        {
              return new RapportParameterBuilder();
        }

        public RapportParameterBuilder()
        {
              Instance = new RapportParameter();            
        }

      


        #endregion

        #region Properties
        
        public RapportParameterBuilder ConcernInfo(ConcernInfo value)
        {
            Instance.ConcernInfo = value;
            return this;
        }

      


        public RapportParameterBuilder Omgeving(Omgeving value)
        {
            Instance.Omgeving = value;
            return this;
        }

      


        public RapportParameterBuilder Taal(String value)
        {
            Instance.Taal = value;
            return this;
        }

      


        public RapportParameterBuilder Placeholders(Dictionary<String,String> value)
        {
            Instance.Placeholders = value;
            return this;
        }

      


        public RapportParameterBuilder KlantOSL(String value)
        {
            Instance.KlantOSL = value;
            return this;
        }

      


        public RapportParameterBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public RapportParameterBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class RapportUitvoerenKenmerkenBuilder : BaseBuilder<RapportUitvoerenKenmerken,RapportUitvoerenKenmerkenBuilder>
        {

        #region Constructors
        
        public static RapportUitvoerenKenmerkenBuilder Init()
        {
              return new RapportUitvoerenKenmerkenBuilder();
        }

        public RapportUitvoerenKenmerkenBuilder()
        {
              Instance = new RapportUitvoerenKenmerken();            
        }

      


        #endregion

        #region Properties
        
        public RapportUitvoerenKenmerkenBuilder AggregatiePeriode(AggregatiePeriode value)
        {
            Instance.AggregatiePeriode = value;
            return this;
        }

      


        public RapportUitvoerenKenmerkenBuilder HistorischeBeginDatum(Nullable<DateTime> value)
        {
            Instance.HistorischeBeginDatum = value;
            return this;
        }

      


        public RapportUitvoerenKenmerkenBuilder HistorischeEindDatum(Nullable<DateTime> value)
        {
            Instance.HistorischeEindDatum = value;
            return this;
        }

      


        public RapportUitvoerenKenmerkenBuilder HistorischUitvoeren(Boolean value)
        {
            Instance.HistorischUitvoeren = value;
            return this;
        }

      


        public RapportUitvoerenKenmerkenBuilder PromptSet(PromptSet value)
        {
            Instance.PromptSet = value;
            return this;
        }

      


        public RapportUitvoerenKenmerkenBuilder Selectie(Selectie value)
        {
            Instance.Selectie = value;
            return this;
        }

      


        public RapportUitvoerenKenmerkenBuilder ParentId(Int32 value)
        {
            Instance.ParentId = value;
            return this;
        }

      


        public RapportUitvoerenKenmerkenBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public RapportUitvoerenKenmerkenBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class RapportUitvoerenParametersBuilder : BaseBuilder<RapportUitvoerenParameters,RapportUitvoerenParametersBuilder>
        {

        #region Constructors
        
        public static RapportUitvoerenParametersBuilder Init()
        {
              return new RapportUitvoerenParametersBuilder();
        }

        public RapportUitvoerenParametersBuilder()
        {
              Instance = new RapportUitvoerenParameters();            
        }

      


        #endregion

        #region Properties
        
        public RapportUitvoerenParametersBuilder HistorischUitvoeren(Boolean value)
        {
            Instance.HistorischUitvoeren = value;
            return this;
        }

      


        public RapportUitvoerenParametersBuilder HistorischeBeginDatum(Nullable<DateTime> value)
        {
            Instance.HistorischeBeginDatum = value;
            return this;
        }

      


        public RapportUitvoerenParametersBuilder HistorischeEindDatum(Nullable<DateTime> value)
        {
            Instance.HistorischeEindDatum = value;
            return this;
        }

      


        public RapportUitvoerenParametersBuilder AggregatiePeriode(AggregatiePeriode value)
        {
            Instance.AggregatiePeriode = value;
            return this;
        }

      


        public RapportUitvoerenParametersBuilder Taal(String value)
        {
            Instance.Taal = value;
            return this;
        }

      


        public RapportUitvoerenParametersBuilder RapportType(RapportType value)
        {
            Instance.RapportType = value;
            return this;
        }

      


        public RapportUitvoerenParametersBuilder PromptSet(PromptSet value)
        {
            Instance.PromptSet = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class RapportUitvoeringResultaatBuilder : BaseBuilder<RapportUitvoeringResultaat,RapportUitvoeringResultaatBuilder>
        {

        #region Constructors
        
        public static RapportUitvoeringResultaatBuilder Init()
        {
              return new RapportUitvoeringResultaatBuilder();
        }

        public RapportUitvoeringResultaatBuilder()
        {
              Instance = new RapportUitvoeringResultaat();            
        }

      


        #endregion

        #region Properties
        
        public RapportUitvoeringResultaatBuilder Resultaat(DataSet value)
        {
            Instance.Resultaat = value;
            return this;
        }

      


        public RapportUitvoeringResultaatBuilder RapportKolomInfos(IList<IRapportKolomInfo> value)
        {
            Instance.RapportKolomInfos = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class RapportVeldKenmerkenBuilder : BaseBuilder<RapportVeldKenmerken,RapportVeldKenmerkenBuilder>
        {

        #region Constructors
        
        public static RapportVeldKenmerkenBuilder Init()
        {
              return new RapportVeldKenmerkenBuilder();
        }

        public RapportVeldKenmerkenBuilder()
        {
              Instance = new RapportVeldKenmerken();            
        }

      


        #endregion

        #region Properties
        
        public RapportVeldKenmerkenBuilder HistorischUitvoeren(Boolean value)
        {
            Instance.HistorischUitvoeren = value;
            return this;
        }

      


        public RapportVeldKenmerkenBuilder HistorischeReferentieDatum(Waarde value)
        {
            Instance.HistorischeReferentieDatum = value;
            return this;
        }

      


        public RapportVeldKenmerkenBuilder VolgNummer(Int32 value)
        {
            Instance.VolgNummer = value;
            return this;
        }

      


        public RapportVeldKenmerkenBuilder Titel(Collection<Omschrijving> value)
        {
            Instance.Titel = value;
            return this;
        }

      


        public RapportVeldKenmerkenBuilder ParentId(Int32 value)
        {
            Instance.ParentId = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class RubriekRapportVeldBuilder : BaseBuilder<RubriekRapportVeld,RubriekRapportVeldBuilder>
        {

        #region Constructors
        
        public static RubriekRapportVeldBuilder Init()
        {
              return new RubriekRapportVeldBuilder();
        }

        public RubriekRapportVeldBuilder()
        {
              Instance = new RubriekRapportVeld();            
        }

      


        #endregion

        #region Properties
        
        public RubriekRapportVeldBuilder ParameterVoorstelling(ParameterVoorstelling value)
        {
            Instance.ParameterVoorstelling = value;
            return this;
        }

      


        public RubriekRapportVeldBuilder MetaDataWaarde(IMetaDataWaarde value)
        {
            Instance.MetaDataWaarde = value;
            return this;
        }

      


        public RubriekRapportVeldBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public RubriekRapportVeldBuilder Omschrijvingen(Collection<Omschrijving> value)
        {
            Instance.Omschrijvingen = value;
            return this;
        }

      


        public RubriekRapportVeldBuilder ClusterID(Nullable<Int32> value)
        {
            Instance.ClusterID = value;
            return this;
        }

      


        public RubriekRapportVeldBuilder ClusterBoomCode(String value)
        {
            Instance.ClusterBoomCode = value;
            return this;
        }

      


        public RubriekRapportVeldBuilder Waarde(RubriekWaarde value)
        {
            Instance.Waarde = value;
            return this;
        }

      


        public RubriekRapportVeldBuilder Kenmerken(RapportVeldKenmerken value)
        {
            Instance.Kenmerken = value;
            return this;
        }

      


        public RubriekRapportVeldBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public RubriekRapportVeldBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class SorteringBuilder : BaseBuilder<Sortering,SorteringBuilder>
        {

        #region Constructors
        
        public static SorteringBuilder Init()
        {
              return new SorteringBuilder();
        }

        public SorteringBuilder()
        {
              Instance = new Sortering();            
        }

      


        #endregion

        #region Properties
        
        public SorteringBuilder RapportVeldID(Int32 value)
        {
            Instance.RapportVeldID = value;
            return this;
        }

      


        public SorteringBuilder VolgNummer(Int32 value)
        {
            Instance.VolgNummer = value;
            return this;
        }

      


        public SorteringBuilder Type(String value)
        {
            Instance.Type = value;
            return this;
        }

      


        public SorteringBuilder Id(Int32 value)
        {
            Instance.Id = value;
            return this;
        }

      


        public SorteringBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public SorteringBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class TussenResultaatRapportVeldBuilder : BaseBuilder<TussenResultaatRapportVeld,TussenResultaatRapportVeldBuilder>
        {

        #region Constructors
        
        public static TussenResultaatRapportVeldBuilder Init()
        {
              return new TussenResultaatRapportVeldBuilder();
        }

        public TussenResultaatRapportVeldBuilder()
        {
              Instance = new TussenResultaatRapportVeld();            
        }

      


        #endregion

        #region Properties
        
        public TussenResultaatRapportVeldBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public TussenResultaatRapportVeldBuilder Omschrijvingen(Collection<Omschrijving> value)
        {
            Instance.Omschrijvingen = value;
            return this;
        }

      


        public TussenResultaatRapportVeldBuilder ClusterID(Nullable<Int32> value)
        {
            Instance.ClusterID = value;
            return this;
        }

      


        public TussenResultaatRapportVeldBuilder ClusterBoomCode(String value)
        {
            Instance.ClusterBoomCode = value;
            return this;
        }

      


        public TussenResultaatRapportVeldBuilder Waarde(TussenResultaatWaarde value)
        {
            Instance.Waarde = value;
            return this;
        }

      


        public TussenResultaatRapportVeldBuilder Kenmerken(RapportVeldKenmerken value)
        {
            Instance.Kenmerken = value;
            return this;
        }

      


        public TussenResultaatRapportVeldBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public TussenResultaatRapportVeldBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class FunctieArgumentBuilder : BaseBuilder<FunctieArgument,FunctieArgumentBuilder>
        {

        #region Constructors
        
        public static FunctieArgumentBuilder Init()
        {
              return new FunctieArgumentBuilder();
        }

        public FunctieArgumentBuilder()
        {
              Instance = new FunctieArgument();            
        }

      


        #endregion

        #region Properties
        
        public FunctieArgumentBuilder Naam(String value)
        {
            Instance.Naam = value;
            return this;
        }

      


        public FunctieArgumentBuilder Id(Int32 value)
        {
            Instance.Id = value;
            return this;
        }

      


        public FunctieArgumentBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public FunctieArgumentBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class RubriekDefinitieBuilder : BaseBuilder<RubriekDefinitie,RubriekDefinitieBuilder>
        {

        #region Constructors
        
        public static RubriekDefinitieBuilder Init()
        {
              return new RubriekDefinitieBuilder();
        }

        public RubriekDefinitieBuilder()
        {
              Instance = new RubriekDefinitie();            
        }

      


        #endregion

        #region Properties
        
        public RubriekDefinitieBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public RubriekDefinitieBuilder Naam(String value)
        {
            Instance.Naam = value;
            return this;
        }

      


        public RubriekDefinitieBuilder RubriekDefinitieOSL(String value)
        {
            Instance.RubriekDefinitieOSL = value;
            return this;
        }

      


        public RubriekDefinitieBuilder Omschrijvingen(Collection<Omschrijving> value)
        {
            Instance.Omschrijvingen = value;
            return this;
        }

      


        public RubriekDefinitieBuilder GegevensType(GegevensTypeInfo value)
        {
            Instance.GegevensType = value;
            return this;
        }

      


        public RubriekDefinitieBuilder Niveau(RubriekNiveauType value)
        {
            Instance.Niveau = value;
            return this;
        }

      


        public RubriekDefinitieBuilder IsHistorisch(Boolean value)
        {
            Instance.IsHistorisch = value;
            return this;
        }

      


        public RubriekDefinitieBuilder FunctieArgumenten(Collection<FunctieArgument> value)
        {
            Instance.FunctieArgumenten = value;
            return this;
        }

      


        public RubriekDefinitieBuilder Mapping(IRubriekDefinitieMapping value)
        {
            Instance.Mapping = value;
            return this;
        }

      


        public RubriekDefinitieBuilder AggregatieType(AggregatieType value)
        {
            Instance.AggregatieType = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class KolomMappingBuilder : BaseBuilder<KolomMapping,KolomMappingBuilder>
        {

        #region Constructors
        
        public static KolomMappingBuilder Init()
        {
              return new KolomMappingBuilder();
        }

        public KolomMappingBuilder()
        {
              Instance = new KolomMapping();            
        }

      


        #endregion

        #region Properties
        
        public KolomMappingBuilder KolomNaam(String value)
        {
            Instance.KolomNaam = value;
            return this;
        }

      


        public KolomMappingBuilder FysischGegevensType(FysischGegevensType value)
        {
            Instance.FysischGegevensType = value;
            return this;
        }

      


        public KolomMappingBuilder LogischGegevensType(LogischGegevensType value)
        {
            Instance.LogischGegevensType = value;
            return this;
        }

      


        public KolomMappingBuilder TabelAlias(TabelAlias value)
        {
            Instance.TabelAlias = value;
            return this;
        }

      


        public KolomMappingBuilder Coalesce(Boolean value)
        {
            Instance.Coalesce = value;
            return this;
        }

      


        public KolomMappingBuilder CoalesceWaarde(String value)
        {
            Instance.CoalesceWaarde = value;
            return this;
        }

      


        public KolomMappingBuilder IsVoordeelMapping(Boolean value)
        {
            Instance.IsVoordeelMapping = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class SQLStatementMappingBuilder : BaseBuilder<SQLStatementMapping,SQLStatementMappingBuilder>
        {

        #region Constructors
        
        public static SQLStatementMappingBuilder Init()
        {
              return new SQLStatementMappingBuilder();
        }

        public SQLStatementMappingBuilder()
        {
              Instance = new SQLStatementMapping();            
        }

      


        #endregion

        #region Properties
        
        public SQLStatementMappingBuilder SqlStatement(String value)
        {
            Instance.SqlStatement = value;
            return this;
        }

      


        public SQLStatementMappingBuilder FysischGegevensType(FysischGegevensType value)
        {
            Instance.FysischGegevensType = value;
            return this;
        }

      


        public SQLStatementMappingBuilder LogischGegevensType(LogischGegevensType value)
        {
            Instance.LogischGegevensType = value;
            return this;
        }

      


        public SQLStatementMappingBuilder TabelAlias(TabelAlias value)
        {
            Instance.TabelAlias = value;
            return this;
        }

      


        public SQLStatementMappingBuilder Coalesce(Boolean value)
        {
            Instance.Coalesce = value;
            return this;
        }

      


        public SQLStatementMappingBuilder CoalesceWaarde(String value)
        {
            Instance.CoalesceWaarde = value;
            return this;
        }

      


        public SQLStatementMappingBuilder IsVoordeelMapping(Boolean value)
        {
            Instance.IsVoordeelMapping = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class CriteriumBuilder : BaseBuilder<Criterium,CriteriumBuilder>
        {

        #region Constructors
        
        public static CriteriumBuilder Init()
        {
              return new CriteriumBuilder();
        }

        public CriteriumBuilder()
        {
              Instance = new Criterium();            
        }

      


        #endregion

        #region Properties
        
        public CriteriumBuilder LinkerArgument(Waarde value)
        {
            Instance.LinkerArgument = value;
            return this;
        }

      


        public CriteriumBuilder CriteriumOperator(String value)
        {
            Instance.CriteriumOperator = value;
            return this;
        }

      


        public CriteriumBuilder RechterArgument(Waarde value)
        {
            Instance.RechterArgument = value;
            return this;
        }

      


        public CriteriumBuilder LijnNummer(Int32 value)
        {
            Instance.LijnNummer = value;
            return this;
        }

      


        public CriteriumBuilder LogischeOperator(String value)
        {
            Instance.LogischeOperator = value;
            return this;
        }

      


        public CriteriumBuilder AantalOpenHaakjes(Int32 value)
        {
            Instance.AantalOpenHaakjes = value;
            return this;
        }

      


        public CriteriumBuilder AantalSluitHaakjes(Int32 value)
        {
            Instance.AantalSluitHaakjes = value;
            return this;
        }

      


        public CriteriumBuilder Id(Int32 value)
        {
            Instance.Id = value;
            return this;
        }

      


        public CriteriumBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public CriteriumBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class SelectieBuilder : BaseBuilder<Selectie,SelectieBuilder>
        {

        #region Constructors
        
        public static SelectieBuilder Init()
        {
              return new SelectieBuilder();
        }

        public SelectieBuilder()
        {
              Instance = new Selectie();            
        }

      


        #endregion

        #region Properties
        
        public SelectieBuilder Criteria(IList<ICriterium> value)
        {
            Instance.Criteria = value;
            return this;
        }

      


        public SelectieBuilder Id(Int32 value)
        {
            Instance.Id = value;
            return this;
        }

      


        public SelectieBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public SelectieBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class BereikWaardeBuilder : BaseBuilder<BereikWaarde,BereikWaardeBuilder>
        {

        #region Constructors
        
        public static BereikWaardeBuilder Init()
        {
              return new BereikWaardeBuilder();
        }

        public BereikWaardeBuilder()
        {
              Instance = new BereikWaarde();            
        }

      


        public static BereikWaardeBuilder Init(DateTime beginDatum , DateTime eindDatum)
        {
              return new BereikWaardeBuilder(beginDatum , eindDatum);
        }

        public BereikWaardeBuilder(DateTime beginDatum , DateTime eindDatum)
        {
              Instance = new BereikWaarde(beginDatum , eindDatum);            
        }

      


        #endregion

        #region Properties
        
        public BereikWaardeBuilder BeginDatum(DateTime value)
        {
            Instance.BeginDatum = value;
            return this;
        }

      


        public BereikWaardeBuilder EindDatum(DateTime value)
        {
            Instance.EindDatum = value;
            return this;
        }

      


        public BereikWaardeBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public BereikWaardeBuilder WaardeType(WaardeType value)
        {
            Instance.WaardeType = value;
            return this;
        }

      


        public BereikWaardeBuilder LogischGegevensType(LogischGegevensType value)
        {
            Instance.LogischGegevensType = value;
            return this;
        }

      


        public BereikWaardeBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public BereikWaardeBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class FunctieWaardeBuilder : BaseBuilder<FunctieWaarde,FunctieWaardeBuilder>
        {

        #region Constructors
        
        public static FunctieWaardeBuilder Init()
        {
              return new FunctieWaardeBuilder();
        }

        public FunctieWaardeBuilder()
        {
              Instance = new FunctieWaarde();            
        }

      


        #endregion

        #region Properties
        
        public FunctieWaardeBuilder FunctieArgumenten(Collection<Waarde> value)
        {
            Instance.FunctieArgumenten = value;
            return this;
        }

      


        public FunctieWaardeBuilder MetaData(MetaData value)
        {
            Instance.MetaData = value;
            return this;
        }

      


        public FunctieWaardeBuilder MetaDataID(IComparable value)
        {
            Instance.MetaDataID = value;
            return this;
        }

      


        public FunctieWaardeBuilder FunctieRubriekDefinitieID(IComparable value)
        {
            Instance.FunctieRubriekDefinitieID = value;
            return this;
        }

      


        public FunctieWaardeBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public FunctieWaardeBuilder WaardeType(WaardeType value)
        {
            Instance.WaardeType = value;
            return this;
        }

      


        public FunctieWaardeBuilder LogischGegevensType(LogischGegevensType value)
        {
            Instance.LogischGegevensType = value;
            return this;
        }

      


        public FunctieWaardeBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public FunctieWaardeBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class LijstWaardeBuilder : BaseBuilder<LijstWaarde,LijstWaardeBuilder>
        {

        #region Constructors
        
        public static LijstWaardeBuilder Init()
        {
              return new LijstWaardeBuilder();
        }

        public LijstWaardeBuilder()
        {
              Instance = new LijstWaarde();            
        }

      


        #endregion

        #region Properties
        
        public LijstWaardeBuilder Inhoud(Collection<Waarde> value)
        {
            Instance.Inhoud = value;
            return this;
        }

      


        public LijstWaardeBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public LijstWaardeBuilder WaardeType(WaardeType value)
        {
            Instance.WaardeType = value;
            return this;
        }

      


        public LijstWaardeBuilder LogischGegevensType(LogischGegevensType value)
        {
            Instance.LogischGegevensType = value;
            return this;
        }

      


        public LijstWaardeBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public LijstWaardeBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class PromptWaardeBuilder : BaseBuilder<PromptWaarde,PromptWaardeBuilder>
        {

        #region Constructors
        
        public static PromptWaardeBuilder Init()
        {
              return new PromptWaardeBuilder();
        }

        public PromptWaardeBuilder()
        {
              Instance = new PromptWaarde();            
        }

      


        #endregion

        #region Properties
        
        public PromptWaardeBuilder PromptDefinitie(PromptDefinitie value)
        {
            Instance.PromptDefinitie = value;
            return this;
        }

      


        public PromptWaardeBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public PromptWaardeBuilder WaardeType(WaardeType value)
        {
            Instance.WaardeType = value;
            return this;
        }

      


        public PromptWaardeBuilder LogischGegevensType(LogischGegevensType value)
        {
            Instance.LogischGegevensType = value;
            return this;
        }

      


        public PromptWaardeBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public PromptWaardeBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class RubriekWaardeBuilder : BaseBuilder<RubriekWaarde,RubriekWaardeBuilder>
        {

        #region Constructors
        
        public static RubriekWaardeBuilder Init()
        {
              return new RubriekWaardeBuilder();
        }

        public RubriekWaardeBuilder()
        {
              Instance = new RubriekWaarde();            
        }

      


        #endregion

        #region Properties
        
        public RubriekWaardeBuilder HistorischeReferentieDatum(Waarde value)
        {
            Instance.HistorischeReferentieDatum = value;
            return this;
        }

      


        public RubriekWaardeBuilder MetaData(MetaData value)
        {
            Instance.MetaData = value;
            return this;
        }

      


        public RubriekWaardeBuilder MetaDataID(IComparable value)
        {
            Instance.MetaDataID = value;
            return this;
        }

      


        public RubriekWaardeBuilder RubriekDefinitieID(IComparable value)
        {
            Instance.RubriekDefinitieID = value;
            return this;
        }

      


        public RubriekWaardeBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public RubriekWaardeBuilder WaardeType(WaardeType value)
        {
            Instance.WaardeType = value;
            return this;
        }

      


        public RubriekWaardeBuilder LogischGegevensType(LogischGegevensType value)
        {
            Instance.LogischGegevensType = value;
            return this;
        }

      


        public RubriekWaardeBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public RubriekWaardeBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class SimpeleWaardeBuilder : BaseBuilder<SimpeleWaarde,SimpeleWaardeBuilder>
        {

        #region Constructors
        
        public static SimpeleWaardeBuilder Init()
        {
              return new SimpeleWaardeBuilder();
        }

        public SimpeleWaardeBuilder()
        {
              Instance = new SimpeleWaarde();            
        }

      


        #endregion

        #region Properties
        
        public SimpeleWaardeBuilder Data(Object value)
        {
            Instance.Data = value;
            return this;
        }

      


        public SimpeleWaardeBuilder IsNietIngevuld(Boolean value)
        {
            Instance.IsNietIngevuld = value;
            return this;
        }

      


        public SimpeleWaardeBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public SimpeleWaardeBuilder WaardeType(WaardeType value)
        {
            Instance.WaardeType = value;
            return this;
        }

      


        public SimpeleWaardeBuilder LogischGegevensType(LogischGegevensType value)
        {
            Instance.LogischGegevensType = value;
            return this;
        }

      


        public SimpeleWaardeBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public SimpeleWaardeBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


        public partial class TussenResultaatWaardeBuilder : BaseBuilder<TussenResultaatWaarde,TussenResultaatWaardeBuilder>
        {

        #region Constructors
        
        public static TussenResultaatWaardeBuilder Init()
        {
              return new TussenResultaatWaardeBuilder();
        }

        public TussenResultaatWaardeBuilder()
        {
              Instance = new TussenResultaatWaarde();            
        }

      


        #endregion

        #region Properties
        
        public TussenResultaatWaardeBuilder Nummer(Int32 value)
        {
            Instance.Nummer = value;
            return this;
        }

      


        public TussenResultaatWaardeBuilder MetaData(MetaData value)
        {
            Instance.MetaData = value;
            return this;
        }

      


        public TussenResultaatWaardeBuilder MetaDataID(IComparable value)
        {
            Instance.MetaDataID = value;
            return this;
        }

      


        public TussenResultaatWaardeBuilder TussenResultaatRubriekDefinitieID(IComparable value)
        {
            Instance.TussenResultaatRubriekDefinitieID = value;
            return this;
        }

      


        public TussenResultaatWaardeBuilder ID(Int32 value)
        {
            Instance.ID = value;
            return this;
        }

      


        public TussenResultaatWaardeBuilder WaardeType(WaardeType value)
        {
            Instance.WaardeType = value;
            return this;
        }

      


        public TussenResultaatWaardeBuilder LogischGegevensType(LogischGegevensType value)
        {
            Instance.LogischGegevensType = value;
            return this;
        }

      


        public TussenResultaatWaardeBuilder EntityID(Guid value)
        {
            Instance.EntityID = value;
            return this;
        }

      


        public TussenResultaatWaardeBuilder State(EntityState value)
        {
            Instance.State = value;
            return this;
        }

      


        #endregion

        }

      


            
        public interface IBuilder<T> where T : class
          {
              T Create();
          }

          public abstract partial class BaseBuilder<T, B> : IBuilder<T> where T : class
          {
              protected T Instance {get; set;}

              public T Create()
              {
                  return Instance;
              }       
          }
      
        }

      