-- Table: public.hl_user

-- DROP TABLE IF EXISTS public.hl_user;

CREATE TABLE IF NOT EXISTS public.hl_user
(
    id serial primary key,
    first_name varchar(100) NOT NULL,
    last_name varchar(100) NOT NULL,
    username varchar(100) NOT NULL,
    role_id integer NOT NULL REFERENCES public.enum_user_role (id),
    email varchar(100) NOT NULL,
    phone varchar(20) NOT NULL,
    password_hash varchar(256) NOT NULL,
    salt varchar(100) NOT NULL,
    language_id integer NOT NULL,
    organization_id integer NOT NULL REFERENCES public.info_organization (id),
    refresh_token varchar(256) NOT NULL,
    refresh_token_expire_date timestamp without time zone,
    created_at timestamp without time zone NOT NULL,
    created_user_id integer NOT NULL,
    updated_at timestamp without time zone NOT NULL,
    updated_user_id integer)
