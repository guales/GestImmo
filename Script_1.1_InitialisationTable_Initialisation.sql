/* Création de la table logement */
create table logement(
    id_logement int not null identity primary key,
    photo image,
    nom varchar(255),
    adresse varchar(255),
    code_postal int,
    ville varchar(100),
    taille varchar(255),
    type_logement varchar(100),
    utilisation varchar(255),
    annee_construction int,
    informations_complementaires varchar(255),
    regles_fiscales varchar(255),
    prix_achat int
);

/*Création de la table charge*/
create table charge( 
    id_charge int not null identity primary key, 
    type_charge varchar(100), 
    montant float, 
    periodicite varchar(100), 
    date_charge date, 
    id_logement int,
    foreign key (id_logement) references logement(id_logement) 
);

/*Création de la table piece*/
create table piece( 
    id_piece int not null identity primary key,
    taille float,
    mesure varchar(25),
    id_logement int,
    foreign key (id_logement) references logement(id_logement) 
);

/*Création de la table deblocage_fond*/
create table deblocage_fond( 
    id_deblocage_fond int not null identity primary key,  
    pourcentage float,
    statut varchar(100),
    id_logement int,
    foreign key (id_logement) references logement(id_logement) 
);

/*Création de la table frais*/
create table frais( 
    id_frais int not null identity primary key,
    categorie varchar(100),
    nom varchar(100),
    valeur float,
    id_logement int,
    foreign key (id_logement) references logement(id_logement) 
);

/*Création de la table remboursement*/
create table remboursement( 
    id_remboursement int not null identity primary key,
    nom varchar(100),
    montant_paye float,
    montant_total float,
    id_logement int,
    foreign key (id_logement) references logement(id_logement) 
);

/*Création de la table prêt*/
create table pret( 
    id_pret int not null identity primary key,
    nom varchar(100),
    banque varchar(100),
    montant float,
    duree varchar(100),
    date_debut date,
    date_fin date,
    taux float,
    id_logement int,
    foreign key (id_logement) references logement(id_logement) 
);

/*Création de la table ligne_echeance_pret*/
create table ligne_echeance_pret( 
    id_ligne_echeance_pret int not null identity primary key, 
    date_prelevement date,
    montant_total float,
    montant_capital float,
    montant_interet float,
    statut varchar(100),
    id_pret int,
    foreign key (id_pret) references pret(id_pret) 
);

/*Création de la table frais_pret*/
create table frais_pret( 
    id_frais_pret int not null identity primary key, 
    nom varchar(100),
    montant float,
    date_paiement date,
    statut varchar(100),
    informations_complementaires varchar(255),
    id_pret int,
    foreign key (id_pret) references pret(id_pret) 
);

/*Création de la table assurance*/
create table assurance( 
    id_assurance int not null identity primary key,
    compagnie varchar(100),
    frequence_paiement varchar(100),
    garantie varchar(500),
    id_pret int,
    foreign key (id_pret) references pret(id_pret) 
);

/*Création de la table ligne_echeancier_assurance*/
create table ligne_echeancier_assurance( 
    id_ligne_echeancier_assurance int not null identity primary key, 
    nom varchar(100),
    date_prelevement date,
    motif varchar(255),
    montant float,
    date_debut date,
    date_fin date,
    statut varchar(100),
    id_assurance int,
    foreign key (id_assurance) references assurance(id_assurance) 
);

/*Création de la table base_version*/
create table base_version( 
    nom_patch varchar(100),
    num_patch varchar(25)
);

/*Insertion dans base version*/
insert into base_version values('Initialisation BDD, creation des tables avec id initialisation','1-1');

