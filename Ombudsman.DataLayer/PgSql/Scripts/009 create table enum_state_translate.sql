-- Table: public.enum_state_translate

-- DROP TABLE IF EXISTS public.enum_state_translate;

CREATE TABLE IF NOT EXISTS public.enum_state_translate
(
    id serial primary key,
    owner_id integer NOT NULL REFERENCES public.enum_state (id),
    language_id integer NOT NULL REFERENCES public.enum_language (id),
    column_name varchar(100) NOT NULL,
    translate_text varchar(100) NOT NULL
);