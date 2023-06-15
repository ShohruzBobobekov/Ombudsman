-- Table: public.enum_document_realizer_type_translate

-- DROP TABLE IF EXISTS public.enum_document_realizer_type_translate;

CREATE TABLE IF NOT EXISTS public.enum_document_realizer_type_translate
(
    id serial primary key,
    owner_id integer NOT NULL,
    language_id integer NOT NULL,
    column_name text COLLATE pg_catalog."default" NOT NULL,
    translate_text text COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT fk_enum_document_realizer_type_translate_doc_document_realizat FOREIGN KEY (owner_id)
        REFERENCES public.doc_document_realization_table (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_enum_document_realizer_type_translate_enum_language_languag FOREIGN KEY (language_id)
        REFERENCES public.enum_language (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)