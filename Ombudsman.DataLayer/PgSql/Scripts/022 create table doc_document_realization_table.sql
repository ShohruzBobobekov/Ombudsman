-- Table: public.doc_document_realization_table

-- DROP TABLE IF EXISTS public.doc_document_realization_table;

CREATE TABLE IF NOT EXISTS public.doc_document_realization_table
(
    id serial primary key,
    organization_id integer NOT NULL,
    visa_issuer_full_name varchar(100) NOT NULL,
    visa_issuer_position varchar(500) NOT NULL,
    responsible_employee_full_name varchar(100) NOT NULL,
    responsible_employee_phone varchar(100) NOT NULL,
    date_entered_for_visa date NOT NULL,
    date_of_visa_issuance date NOT NULL,
    owner_id integer NOT NULL REFERENCES public.doc_document_realization (id)
)