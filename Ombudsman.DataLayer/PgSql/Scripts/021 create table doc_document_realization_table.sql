-- Table: public.doc_document_realization_table

-- DROP TABLE IF EXISTS public.doc_document_realization_table;

CREATE TABLE IF NOT EXISTS public.doc_document_realization_table
(
    id serial primary key,
    organization_id integer NOT NULL,
    visa_issuer_full_name text COLLATE pg_catalog."default" NOT NULL,
    visa_issuer_position text COLLATE pg_catalog."default" NOT NULL,
    responsible_employee_full_name text COLLATE pg_catalog."default" NOT NULL,
    responsible_employee_phone text COLLATE pg_catalog."default" NOT NULL,
    date_entered_for_visa date NOT NULL,
    date_of_visa_issuance date NOT NULL,
    owner_id integer NOT NULL,
    CONSTRAINT fk_doc_document_realization_table_doc_document_realization_own FOREIGN KEY (owner_id)
        REFERENCES public.doc_document_realization (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)