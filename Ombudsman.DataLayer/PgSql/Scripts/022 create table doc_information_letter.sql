-- Table: public.doc_information_letter

-- DROP TABLE IF EXISTS public.doc_information_letter;

CREATE TABLE IF NOT EXISTS public.doc_information_letter
(
    id serial primary key,
    doc_number text COLLATE pg_catalog."default",
    doc_date date,
    information_letter_text text COLLATE pg_catalog."default" NOT NULL,
    main_realizer text COLLATE pg_catalog."default" NOT NULL,
    additional_realizers text COLLATE pg_catalog."default" NOT NULL,
    responsible_employee_full_name text COLLATE pg_catalog."default" NOT NULL,
    phone_number text COLLATE pg_catalog."default" NOT NULL,
    owner_id integer NOT NULL,
    full_name text COLLATE pg_catalog."default" NOT NULL,
    short_name text COLLATE pg_catalog."default" NOT NULL,
    created_date timestamp with time zone NOT NULL,
    created_user_id integer NOT NULL,
    updated_date timestamp with time zone NOT NULL,
    updated_user_id integer,
    CONSTRAINT fk_doc_information_letter_doc_document_realization_owner_id FOREIGN KEY (owner_id)
        REFERENCES public.doc_document_realization (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)