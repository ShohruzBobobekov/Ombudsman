-- Table: public.enum_government_organization_type_translate

-- DROP TABLE IF EXISTS public.enum_government_organization_type_translate;

CREATE TABLE IF NOT EXISTS public.enum_government_organization_type_translate
(
    id serial primary key,
    owner_id integer NOT NULL,
    language_id integer NOT NULL,
    column_name text COLLATE pg_catalog."default" NOT NULL,
    translate_text text COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT fk_enum_government_organization_type_translate_enum_government FOREIGN KEY (owner_id)
        REFERENCES public.enum_government_organization_type (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_enum_government_organization_type_translate_enum_language_l FOREIGN KEY (language_id)
        REFERENCES public.enum_language (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)