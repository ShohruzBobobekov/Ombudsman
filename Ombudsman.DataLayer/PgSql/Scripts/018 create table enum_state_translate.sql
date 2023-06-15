-- Table: public.enum_state_translate

-- DROP TABLE IF EXISTS public.enum_state_translate;

CREATE TABLE IF NOT EXISTS public.enum_state_translate
(
    id serial primary key,
    owner_id integer NOT NULL,
    language_id integer NOT NULL,
    column_name text COLLATE pg_catalog."default" NOT NULL,
    translate_text text COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT fk_enum_state_translate_enum_language_language_id FOREIGN KEY (language_id)
        REFERENCES public.enum_language (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_enum_state_translate_enum_state_owner_id FOREIGN KEY (owner_id)
        REFERENCES public.enum_state (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)