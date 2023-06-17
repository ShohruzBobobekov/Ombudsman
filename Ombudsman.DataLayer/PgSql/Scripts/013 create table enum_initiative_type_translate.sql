-- Table: public.enum_initiative_type_translate

-- DROP TABLE IF EXISTS public.enum_initiative_type_translate;

CREATE TABLE IF NOT EXISTS public.enum_initiative_type_translate
(
    id serial primary key,
    owner_id integer NOT NULL REFERENCES public.enum_initiative_type (id),
    language_id integer NOT NULL REFERENCES public.enum_language (id),
    column_name varchar(100) NOT NULL,
    translate_text varchar(100) NOT NULL
);