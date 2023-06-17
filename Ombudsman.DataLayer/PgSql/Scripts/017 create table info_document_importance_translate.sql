-- Table: public.info_document_importance_translate

-- DROP TABLE IF EXISTS public.info_document_importance_translate;

CREATE TABLE IF NOT EXISTS public.info_document_importance_translate
(
    id serial primary key,
    owner_id integer NOT NULL REFERENCES public.info_document_importance (id),
    language_id integer NOT NULL REFERENCES public.enum_language (id),
    column_name varchar(100) NOT NULL,
    translate_text varchar(100) NOT NULL

)