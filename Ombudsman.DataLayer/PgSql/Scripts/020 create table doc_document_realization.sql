			   -- Table: public.doc_document_realization

-- DROP TABLE IF EXISTS public.doc_document_realization;

CREATE TABLE IF NOT EXISTS public.doc_document_realization
(
    id serial primary key,
    document_speciality text COLLATE pg_catalog."default" NOT NULL,
    is_included_in_state_program boolean NOT NULL,
    state_program_name text COLLATE pg_catalog."default",
    document_summary text COLLATE pg_catalog."default",
    sent_date date NOT NULL,
    responsible_sector_id integer NOT NULL,
    main_ministry text COLLATE pg_catalog."default" NOT NULL,
    main_realizer text COLLATE pg_catalog."default" NOT NULL,
    additional_realizers text COLLATE pg_catalog."default" NOT NULL,
    initiative text COLLATE pg_catalog."default" NOT NULL,
    doc_number text COLLATE pg_catalog."default",
    doc_date date,
    file_id uuid,
    document_type_id integer NOT NULL,
    importance_id integer NOT NULL,
    initiative_type_id integer NOT NULL,
    state_id integer NOT NULL,
    full_name text COLLATE pg_catalog."default" NOT NULL,
    short_name text COLLATE pg_catalog."default" NOT NULL,
    created_date timestamp with time zone NOT NULL,
    created_user_id integer NOT NULL,
    updated_date timestamp with time zone NOT NULL,
    updated_user_id integer,
    CONSTRAINT fk_doc_document_realization_enum_document_type_document_type_id FOREIGN KEY (document_type_id)
        REFERENCES public.enum_document_type (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_doc_document_realization_enum_initiative_type_initiative_typ FOREIGN KEY (initiative_type_id)
        REFERENCES public.enum_initiative_type (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_doc_document_realization_enum_state_state_id FOREIGN KEY (state_id)
        REFERENCES public.enum_state (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_doc_document_realization_info_document_importance_importanc FOREIGN KEY (importance_id)
        REFERENCES public.info_document_importance (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_doc_document_realization_info_sector_responsible_sector_id FOREIGN KEY (responsible_sector_id)
        REFERENCES public.info_sector (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_doc_document_realization_sys_file_file_id FOREIGN KEY (file_id)
        REFERENCES public.sys_file (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
