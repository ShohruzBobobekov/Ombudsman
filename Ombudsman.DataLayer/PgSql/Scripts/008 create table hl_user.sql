-- Table: public.hl_user

-- DROP TABLE IF EXISTS public.hl_user;

CREATE TABLE IF NOT EXISTS public.hl_user
(
    id serial primary key,
    first_name text COLLATE pg_catalog."default" NOT NULL,
    last_name text COLLATE pg_catalog."default" NOT NULL,
    username text COLLATE pg_catalog."default" NOT NULL,
    role_id integer NOT NULL,
    email text COLLATE pg_catalog."default",
    phone text COLLATE pg_catalog."default",
    password_hash text COLLATE pg_catalog."default" NOT NULL,
    salt text COLLATE pg_catalog."default" NOT NULL,
    language_id integer NOT NULL,
    organization_id integer NOT NULL,
    refresh_token text COLLATE pg_catalog."default",
    refresh_token_expire_date timestamp with time zone,
    full_name text COLLATE pg_catalog."default" NOT NULL,
    short_name text COLLATE pg_catalog."default" NOT NULL,
    created_date timestamp with time zone NOT NULL,
    created_user_id integer NOT NULL,
    updated_date timestamp with time zone NOT NULL,
    updated_user_id integer,
    CONSTRAINT fk_hl_user_enum_user_role_role_id FOREIGN KEY (role_id)
        REFERENCES public.enum_user_role (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_hl_user_info_organization_organization_id FOREIGN KEY (organization_id)
        REFERENCES public.info_organization (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)
