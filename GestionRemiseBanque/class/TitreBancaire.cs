using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TitreBancaire
{
    private String numero;
    private DateTime echeance;
    private double montant;
    private int societeId;
    private int banqueId;
    private int compteId;
    private Boolean isCheque;
    private Boolean isChqHorsPlace;
    private int remiseID;
    private int createdBy;
    private DateTime dateCreation;
    private int modifiedBy;
    private DateTime dateModification;

    public TitreBancaire(String numero, DateTime echeance, double montant,
        int societeId, int banqueId, int compteId, Boolean isCheque,
        Boolean isChqHorsPlace,int remiseID ,int createdBy, DateTime dateCreation, int modifiedBy, DateTime dateModification)
    {

        this.numero = numero;
        this.echeance = echeance;
        this.montant = montant;
        this.societeId = societeId;
        this.banqueId = banqueId;
        this.compteId = compteId;
        this.isCheque = isCheque;
        this.isChqHorsPlace = isChqHorsPlace;
        this.remiseID = remiseID;
        this.createdBy = createdBy;
        this.dateCreation = dateCreation;
        this.modifiedBy = modifiedBy;
        this.DateModification = dateModification;

    }

    public string Numero   // property
    {
        get { return numero; }   // get method
        set { numero = value; }  // set method
    }

    public DateTime Echeance   // property
    {
        get { return echeance; }   // get method
        set { echeance = value; }  // set method
    }
    public double Montant   // property
    {
        get { return montant; }   // get method
        set { montant = value; }  // set method
    }
    public int SocieteID   // property
    {
        get { return societeId; }   // get method
        set { societeId = value; }  // set method
    }

    public int BanqueID   // property
    {
        get { return banqueId; }   // get method
        set { banqueId = value; }  // set method
    }

    public int CompteID   // property
    {
        get { return compteId; }   // get method
        set { compteId = value; }  // set method
    }
    public Boolean IsCheque   // property
    {
        get { return isCheque; }   // get method
        set { isCheque = value; }  // set method
    }

    public Boolean IsChequeHorsPlace   // property
    {
        get { return isChqHorsPlace; }   // get method
        set { isChqHorsPlace = value; }  // set method
    }

    public int RemiseID   // property
    {
        get { return remiseID; }   // get method
        set { remiseID = value; }  // set method
    }
    public int CreatedBy   // property
    {
        get { return createdBy; }   // get method
        set { createdBy = value; }  // set method
    }

    public int ModifiedBy   // property
    {
        get { return modifiedBy; }   // get method
        set { modifiedBy = value; }  // set method
    }

    public DateTime DateCreation   // property
    {
        get { return dateCreation; }   // get method
        set { dateCreation = value; }  // set method
    }
    public DateTime DateModification   // property
    {
        get { return dateModification; }   // get method
        set { dateModification = value; }  // set method
    }
}

