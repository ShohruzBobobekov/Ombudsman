-- Table: public.info_document_importance_translate

-- DROP TABLE IF EXISTS public.info_document_importance_translate;

CREATE TABLE IF NOT EXISTS public.info_document_importance_translate
(
    id serial primary key,
    owner_id integer NOT NULL,
    language_id integer NOT NULL,
    column_name text COLLATE pg_catalog."default" NOT NULL,
    translate_text text COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT fk_info_document_importance_translate_enum_language_language_id FOREIGN KEY (language_id)
        REFERENCES public.enum_language (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_info_document_importance_translate_info_document_importance FOREIGN KEY (owner_id)
        REFERENCES public.info_document_importance (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)