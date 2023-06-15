-- Table: public.enum_user_role

-- DROP TABLE IF EXISTS public.enum_user_role;

CREATE TABLE IF NOT EXISTS public.enum_user_role
(
    id serial primary key,
    order_number text COLLATE pg_catalog."default" NOT NULL,
    short_name text COLLATE pg_catalog."default" NOT NULL,
    full_name text COLLATE pg_catalog."default" NOT NULL,
    state_id integer NOT NULL,
    CONSTRAINT fk_enum_user_role_enum_state_state_id FOREIGN KEY (state_id)
        REFERENCES public.enum_state (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)