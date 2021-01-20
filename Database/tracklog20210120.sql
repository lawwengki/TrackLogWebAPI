PGDMP                          y            HAWOOO_userlogs    13.0    13.0 S               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                        0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            !           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            "           1262    16394    HAWOOO_userlogs    DATABASE     u   CREATE DATABASE "HAWOOO_userlogs" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
 !   DROP DATABASE "HAWOOO_userlogs";
                postgres    false            �            1255    17197    usp_getaddtocart()    FUNCTION     �  CREATE FUNCTION public.usp_getaddtocart() RETURNS TABLE(_eventid bigint, _currency character varying, _total_value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob timestamp without time zone, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
   RETURN QUERY
   SELECT eventid, 
   currency,
   total_value,
   url,
   email,
   first_name,
   last_name,
   phone,
   gender,
   DOB,
   city,                        
   state, 
   country,
   user_ip,
   browser_user_agent, 
   clickid ,
   browserid ,
   fb_loginid 
   FROM add_to_cart_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 )   DROP FUNCTION public.usp_getaddtocart();
       public          postgres    false            �            1255    17205    usp_getaddtowishlist()    FUNCTION     �  CREATE FUNCTION public.usp_getaddtowishlist() RETURNS TABLE(_eventid bigint, _currency character varying, _value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob timestamp without time zone, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
   RETURN QUERY
   SELECT eventid, 
   currency,
   value,
   url,
   email,
   first_name,
   last_name,
   phone,
   gender,
   DOB,
   city,                        
   state, 
   country,
   user_ip,
   browser_user_agent, 
   clickid ,
   browserid ,
   fb_loginid 
   FROM add_to_cart_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 -   DROP FUNCTION public.usp_getaddtowishlist();
       public          postgres    false            �            1255    17206    usp_getcompleteregistration()    FUNCTION     !  CREATE FUNCTION public.usp_getcompleteregistration() RETURNS TABLE(_eventid bigint, _content_name character varying, _reg_status character varying, _currency character varying, _total_value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob timestamp without time zone, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
   RETURN QUERY
   SELECT eventid, 
   content_name,
   reg_status
   currency,
   total_value,
   url,
   email,
   first_name,
   last_name,
   phone,
   gender,
   DOB,
   city,                        
   state, 
   country,
   user_ip,
   browser_user_agent, 
   clickid ,
   browserid ,
   fb_loginid 
   FROM add_to_cart_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 4   DROP FUNCTION public.usp_getcompleteregistration();
       public          postgres    false            �            1255    17207    usp_getinitiatecheckout()    FUNCTION     �  CREATE FUNCTION public.usp_getinitiatecheckout() RETURNS TABLE(_eventid bigint, _currency character varying, _total_value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob timestamp without time zone, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
   RETURN QUERY
   SELECT eventid, 
   currency,
   total_value,
   url,
   email,
   first_name,
   last_name,
   phone,
   gender,
   DOB,
   city,                        
   state, 
   country,
   user_ip,
   browser_user_agent, 
   clickid ,
   browserid ,
   fb_loginid 
   FROM add_to_cart_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 0   DROP FUNCTION public.usp_getinitiatecheckout();
       public          postgres    false            �            1255    17208    usp_getpageview()    FUNCTION     f  CREATE FUNCTION public.usp_getpageview() RETURNS TABLE(_eventid bigint, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob timestamp without time zone, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
   RETURN QUERY
   SELECT eventid, 
   url,
   email,
   first_name,
   last_name,
   phone,
   gender,
   DOB,
   city,                        
   state, 
   country,
   user_ip,
   browser_user_agent, 
   clickid ,
   browserid ,
   fb_loginid 
   FROM add_to_cart_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 (   DROP FUNCTION public.usp_getpageview();
       public          postgres    false            �            1255    17204    usp_getpaymentinfo()    FUNCTION     �  CREATE FUNCTION public.usp_getpaymentinfo() RETURNS TABLE(_eventid bigint, _currency character varying, _value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob timestamp without time zone, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
   RETURN QUERY
   SELECT eventid, 
   currency,
   value,
   url,
   email,
   first_name,
   last_name,
   phone,
   gender,
   DOB,
   city,                        
   state, 
   country,
   user_ip,
   browser_user_agent, 
   clickid ,
   browserid ,
   fb_loginid 
   FROM add_payment_info_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 +   DROP FUNCTION public.usp_getpaymentinfo();
       public          postgres    false            �            1255    17203    usp_getproducts(bigint)    FUNCTION     �  CREATE FUNCTION public.usp_getproducts(_eventid bigint) RETURNS TABLE(_productid bigint, _quantity integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
   RETURN QUERY
   SELECT products.productid,
   products.quantity  
   FROM add_to_cart_lg  inner join products ON add_to_cart_lg.eventid = products.eventid 
   WHERE status = 1 AND add_to_cart_lg.eventid = _eventid
   order by add_to_cart_lg.eventid, createtimestamp asc;  
   

			
END;
$$;
 7   DROP FUNCTION public.usp_getproducts(_eventid bigint);
       public          postgres    false            �            1255    17209    usp_getpurchasedata()    FUNCTION     �  CREATE FUNCTION public.usp_getpurchasedata() RETURNS TABLE(_eventid bigint, _currency character varying, _total_value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob timestamp without time zone, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
   RETURN QUERY
   SELECT eventid, 
   currency,
   total_value,
   url,
   email,
   first_name,
   last_name,
   phone,
   gender,
   DOB,
   city,                        
   state, 
   country,
   user_ip,
   browser_user_agent, 
   clickid ,
   browserid ,
   fb_loginid 
   FROM add_to_cart_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 ,   DROP FUNCTION public.usp_getpurchasedata();
       public          postgres    false            �            1255    17210    usp_getsearch()    FUNCTION     �  CREATE FUNCTION public.usp_getsearch() RETURNS TABLE(_eventid bigint, _search_str text, _currency character varying, _value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob timestamp without time zone, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
   RETURN QUERY
   SELECT eventid, 
   search_str,
   currency,
   value,
   url,
   email,
   first_name,
   last_name,
   phone,
   gender,
   DOB,
   city,                        
   state, 
   country,
   user_ip,
   browser_user_agent, 
   clickid ,
   browserid ,
   fb_loginid 
   FROM add_to_cart_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 &   DROP FUNCTION public.usp_getsearch();
       public          postgres    false            �            1255    17211    usp_getsubscribe()    FUNCTION     �  CREATE FUNCTION public.usp_getsubscribe() RETURNS TABLE(_eventid bigint, _predicted_itv character varying, _currency character varying, _total_value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob timestamp without time zone, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
   RETURN QUERY
   SELECT eventid, 
   predicted_itv,
   currency,
   value,
   url,
   email,
   first_name,
   last_name,
   phone,
   gender,
   DOB,
   city,                        
   state, 
   country,
   user_ip,
   browser_user_agent, 
   clickid ,
   browserid ,
   fb_loginid 
   FROM add_to_cart_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 )   DROP FUNCTION public.usp_getsubscribe();
       public          postgres    false            �            1259    17052    add_payment_info_lg    TABLE     d  CREATE TABLE public.add_payment_info_lg (
    seqid integer NOT NULL,
    eventid bigint NOT NULL,
    currency character varying(3),
    value numeric(10,2),
    url text,
    type integer,
    credit_points bigint,
    pay_method integer,
    email character varying(500),
    first_name character varying(50),
    last_name character varying(50),
    phone character varying(50),
    gender character varying(6),
    dob timestamp without time zone,
    city character varying(100),
    state character varying(15),
    country character varying(15),
    browser_sessionid character varying(500),
    user_ip character varying(100),
    browser_user_agent character varying(1000),
    clickid character varying(500),
    browserid character varying(500),
    fb_loginid character varying(500),
    createtimestamp timestamp without time zone,
    status integer
);
 '   DROP TABLE public.add_payment_info_lg;
       public         heap    postgres    false            �            1259    17050    add_payment_info_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.add_payment_info_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE public.add_payment_info_lg_seqid_seq;
       public          postgres    false    201            #           0    0    add_payment_info_lg_seqid_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public.add_payment_info_lg_seqid_seq OWNED BY public.add_payment_info_lg.seqid;
          public          postgres    false    200            �            1259    17063    add_to_cart_lg    TABLE     3  CREATE TABLE public.add_to_cart_lg (
    seqid integer NOT NULL,
    eventid bigint NOT NULL,
    currency character varying(3),
    total_value numeric(10,2),
    url text,
    type integer,
    email character varying(500),
    first_name character varying(50),
    last_name character varying(50),
    phone character varying(50),
    gender character varying(6),
    dob timestamp without time zone,
    city character varying(100),
    state character varying(15),
    country character varying(15),
    browser_sessionid character varying(500),
    user_ip character varying(100),
    browser_user_agent character varying(1000),
    clickid character varying(500),
    browserid character varying(500),
    fb_loginid character varying(500),
    createtimestamp timestamp without time zone,
    status integer
);
 "   DROP TABLE public.add_to_cart_lg;
       public         heap    postgres    false            �            1259    17061    add_to_cart_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.add_to_cart_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.add_to_cart_lg_seqid_seq;
       public          postgres    false    203            $           0    0    add_to_cart_lg_seqid_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.add_to_cart_lg_seqid_seq OWNED BY public.add_to_cart_lg.seqid;
          public          postgres    false    202            �            1259    17160    add_to_wish_list_lg    TABLE     2  CREATE TABLE public.add_to_wish_list_lg (
    seqid integer NOT NULL,
    eventid bigint NOT NULL,
    currency character varying(3),
    value numeric(10,2),
    url text,
    type integer,
    email character varying(500),
    first_name character varying(50),
    last_name character varying(50),
    phone character varying(50),
    gender character varying(6),
    dob timestamp without time zone,
    city character varying(100),
    state character varying(15),
    country character varying(15),
    browser_sessionid character varying(100),
    user_ip character varying(100),
    browser_user_agent character varying(1000),
    clickid character varying(100),
    browserid character varying(100),
    fb_loginid character varying(100),
    createtimestamp timestamp without time zone,
    status integer
);
 '   DROP TABLE public.add_to_wish_list_lg;
       public         heap    postgres    false            �            1259    17158    add_to_wish_list_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.add_to_wish_list_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE public.add_to_wish_list_lg_seqid_seq;
       public          postgres    false    217            %           0    0    add_to_wish_list_lg_seqid_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public.add_to_wish_list_lg_seqid_seq OWNED BY public.add_to_wish_list_lg.seqid;
          public          postgres    false    216            �            1259    17076    complete_reg_lg    TABLE     c  CREATE TABLE public.complete_reg_lg (
    seqid integer NOT NULL,
    eventid bigint NOT NULL,
    content_name character varying(100),
    reg_status character varying(10),
    currency character varying(3),
    total_value numeric(10,2),
    email character varying(500),
    first_name character varying(50),
    last_name character varying(50),
    phone character varying(50),
    gender character varying(6),
    dob timestamp without time zone,
    city character varying(100),
    state character varying(15),
    country character varying(15),
    browser_sessionid character varying(500),
    user_ip character varying(100),
    browser_user_agent character varying(1000),
    clickid character varying(500),
    browserid character varying(500),
    fb_loginid character varying(500),
    createtimestamp timestamp without time zone,
    status integer
);
 #   DROP TABLE public.complete_reg_lg;
       public         heap    postgres    false            �            1259    17074    complete_reg_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.complete_reg_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public.complete_reg_lg_seqid_seq;
       public          postgres    false    205            &           0    0    complete_reg_lg_seqid_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public.complete_reg_lg_seqid_seq OWNED BY public.complete_reg_lg.seqid;
          public          postgres    false    204            �            1259    17088    init_checkout_lg    TABLE     #  CREATE TABLE public.init_checkout_lg (
    seqid integer NOT NULL,
    eventid bigint NOT NULL,
    currency character varying(3),
    total_value numeric(10,2),
    url text,
    email character varying(500),
    first_name character varying(50),
    last_name character varying(50),
    phone character varying(50),
    gender character varying(6),
    dob timestamp without time zone,
    city character varying(100),
    state character varying(15),
    country character varying(15),
    browser_sessionid character varying(500),
    user_ip character varying(100),
    browser_user_agent character varying(1000),
    clickid character varying(500),
    browserid character varying(500),
    fb_loginid character varying(500),
    createtimestamp timestamp without time zone,
    status integer
);
 $   DROP TABLE public.init_checkout_lg;
       public         heap    postgres    false            �            1259    17086    init_checkout_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.init_checkout_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.init_checkout_lg_seqid_seq;
       public          postgres    false    207            '           0    0    init_checkout_lg_seqid_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.init_checkout_lg_seqid_seq OWNED BY public.init_checkout_lg.seqid;
          public          postgres    false    206            �            1259    17099    page_view_lg    TABLE     �  CREATE TABLE public.page_view_lg (
    seqid integer NOT NULL,
    eventid bigint NOT NULL,
    url text,
    email character varying(500),
    first_name character varying(50),
    last_name character varying(50),
    phone character varying(50),
    gender character varying(6),
    dob timestamp without time zone,
    city character varying(100),
    state character varying(15),
    country character varying(15),
    browser_sessionid character varying(500),
    user_ip character varying(100),
    browser_user_agent character varying(1000),
    clickid character varying(500),
    browserid character varying(500),
    fb_loginid character varying(500),
    createtimestamp timestamp without time zone,
    status integer
);
     DROP TABLE public.page_view_lg;
       public         heap    postgres    false            �            1259    17097    page_view_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.page_view_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.page_view_lg_seqid_seq;
       public          postgres    false    209            (           0    0    page_view_lg_seqid_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.page_view_lg_seqid_seq OWNED BY public.page_view_lg.seqid;
          public          postgres    false    208            �            1259    17110    products    TABLE     �   CREATE TABLE public.products (
    seqid integer NOT NULL,
    eventid bigint NOT NULL,
    productid bigint,
    quantity integer
);
    DROP TABLE public.products;
       public         heap    postgres    false            �            1259    17108    products_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.products_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.products_seqid_seq;
       public          postgres    false    211            )           0    0    products_seqid_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.products_seqid_seq OWNED BY public.products.seqid;
          public          postgres    false    210            �            1259    17118    purchase_lg    TABLE     0  CREATE TABLE public.purchase_lg (
    seqid integer NOT NULL,
    eventid bigint NOT NULL,
    currency character varying(3),
    total_value numeric(10,2),
    url text,
    type integer,
    email character varying(500),
    first_name character varying(50),
    last_name character varying(50),
    phone character varying(50),
    gender character varying(6),
    dob timestamp without time zone,
    city character varying(100),
    state character varying(15),
    country character varying(15),
    browser_sessionid character varying(500),
    user_ip character varying(100),
    browser_user_agent character varying(1000),
    clickid character varying(500),
    browserid character varying(500),
    fb_loginid character varying(500),
    createtimestamp timestamp without time zone,
    status integer
);
    DROP TABLE public.purchase_lg;
       public         heap    postgres    false            �            1259    17116    purchase_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.purchase_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.purchase_lg_seqid_seq;
       public          postgres    false    213            *           0    0    purchase_lg_seqid_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.purchase_lg_seqid_seq OWNED BY public.purchase_lg.seqid;
          public          postgres    false    212            �            1259    17171 	   search_lg    TABLE     +  CREATE TABLE public.search_lg (
    seqid integer NOT NULL,
    eventid bigint NOT NULL,
    search_str text,
    currency character varying(3),
    value numeric(10,2),
    url text,
    email character varying(500),
    first_name character varying(50),
    last_name character varying(50),
    phone character varying(50),
    gender character varying(6),
    dob timestamp without time zone,
    city character varying(100),
    state character varying(15),
    country character varying(15),
    browser_sessionid character varying(500),
    user_ip character varying(100),
    browser_user_agent character varying(1000),
    clickid character varying(500),
    browserid character varying(500),
    fb_loginid character varying(500),
    createtimestamp timestamp without time zone,
    status integer
);
    DROP TABLE public.search_lg;
       public         heap    postgres    false            �            1259    17169    search_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.search_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public.search_lg_seqid_seq;
       public          postgres    false    219            +           0    0    search_lg_seqid_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public.search_lg_seqid_seq OWNED BY public.search_lg.seqid;
          public          postgres    false    218            �            1259    17137    subscribe_lg    TABLE     B  CREATE TABLE public.subscribe_lg (
    seqid integer NOT NULL,
    eventid bigint NOT NULL,
    predicted_itv character varying(20),
    currency character varying(3),
    value numeric(10,2),
    url text,
    email character varying(500),
    first_name character varying(50),
    last_name character varying(50),
    phone character varying(50),
    gender character varying(6),
    dob timestamp without time zone,
    city character varying(100),
    state character varying(15),
    country character varying(15),
    browser_sessionid character varying(500),
    user_ip character varying(100),
    browser_user_agent character varying(1000),
    clickid character varying(500),
    browserid character varying(500),
    fb_loginid character varying(500),
    createtimestamp timestamp without time zone,
    status integer
);
     DROP TABLE public.subscribe_lg;
       public         heap    postgres    false            �            1259    17135    subscribe_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.subscribe_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.subscribe_lg_seqid_seq;
       public          postgres    false    215            ,           0    0    subscribe_lg_seqid_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.subscribe_lg_seqid_seq OWNED BY public.subscribe_lg.seqid;
          public          postgres    false    214            k           2604    17055    add_payment_info_lg seqid    DEFAULT     �   ALTER TABLE ONLY public.add_payment_info_lg ALTER COLUMN seqid SET DEFAULT nextval('public.add_payment_info_lg_seqid_seq'::regclass);
 H   ALTER TABLE public.add_payment_info_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    201    200    201            l           2604    17066    add_to_cart_lg seqid    DEFAULT     |   ALTER TABLE ONLY public.add_to_cart_lg ALTER COLUMN seqid SET DEFAULT nextval('public.add_to_cart_lg_seqid_seq'::regclass);
 C   ALTER TABLE public.add_to_cart_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    202    203    203            s           2604    17163    add_to_wish_list_lg seqid    DEFAULT     �   ALTER TABLE ONLY public.add_to_wish_list_lg ALTER COLUMN seqid SET DEFAULT nextval('public.add_to_wish_list_lg_seqid_seq'::regclass);
 H   ALTER TABLE public.add_to_wish_list_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    217    216    217            m           2604    17079    complete_reg_lg seqid    DEFAULT     ~   ALTER TABLE ONLY public.complete_reg_lg ALTER COLUMN seqid SET DEFAULT nextval('public.complete_reg_lg_seqid_seq'::regclass);
 D   ALTER TABLE public.complete_reg_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    204    205    205            n           2604    17091    init_checkout_lg seqid    DEFAULT     �   ALTER TABLE ONLY public.init_checkout_lg ALTER COLUMN seqid SET DEFAULT nextval('public.init_checkout_lg_seqid_seq'::regclass);
 E   ALTER TABLE public.init_checkout_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    206    207    207            o           2604    17102    page_view_lg seqid    DEFAULT     x   ALTER TABLE ONLY public.page_view_lg ALTER COLUMN seqid SET DEFAULT nextval('public.page_view_lg_seqid_seq'::regclass);
 A   ALTER TABLE public.page_view_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    209    208    209            p           2604    17113    products seqid    DEFAULT     p   ALTER TABLE ONLY public.products ALTER COLUMN seqid SET DEFAULT nextval('public.products_seqid_seq'::regclass);
 =   ALTER TABLE public.products ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    211    210    211            q           2604    17121    purchase_lg seqid    DEFAULT     v   ALTER TABLE ONLY public.purchase_lg ALTER COLUMN seqid SET DEFAULT nextval('public.purchase_lg_seqid_seq'::regclass);
 @   ALTER TABLE public.purchase_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    213    212    213            t           2604    17174    search_lg seqid    DEFAULT     r   ALTER TABLE ONLY public.search_lg ALTER COLUMN seqid SET DEFAULT nextval('public.search_lg_seqid_seq'::regclass);
 >   ALTER TABLE public.search_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    218    219    219            r           2604    17140    subscribe_lg seqid    DEFAULT     x   ALTER TABLE ONLY public.subscribe_lg ALTER COLUMN seqid SET DEFAULT nextval('public.subscribe_lg_seqid_seq'::regclass);
 A   ALTER TABLE public.subscribe_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    215    214    215            
          0    17052    add_payment_info_lg 
   TABLE DATA           %  COPY public.add_payment_info_lg (seqid, eventid, currency, value, url, type, credit_points, pay_method, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    201   X�                 0    17063    add_to_cart_lg 
   TABLE DATA             COPY public.add_to_cart_lg (seqid, eventid, currency, total_value, url, type, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    203   }�                 0    17160    add_to_wish_list_lg 
   TABLE DATA           
  COPY public.add_to_wish_list_lg (seqid, eventid, currency, value, url, type, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    217   ��                 0    17076    complete_reg_lg 
   TABLE DATA             COPY public.complete_reg_lg (seqid, eventid, content_name, reg_status, currency, total_value, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    205   ¡                 0    17088    init_checkout_lg 
   TABLE DATA             COPY public.init_checkout_lg (seqid, eventid, currency, total_value, url, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    207   ��                 0    17099    page_view_lg 
   TABLE DATA           �   COPY public.page_view_lg (seqid, eventid, url, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    209   p�                 0    17110    products 
   TABLE DATA           G   COPY public.products (seqid, eventid, productid, quantity) FROM stdin;
    public          postgres    false    211   Y�                 0    17118    purchase_lg 
   TABLE DATA             COPY public.purchase_lg (seqid, eventid, currency, total_value, url, type, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    213   �                 0    17171 	   search_lg 
   TABLE DATA             COPY public.search_lg (seqid, eventid, search_str, currency, value, url, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    219   �                 0    17137    subscribe_lg 
   TABLE DATA             COPY public.subscribe_lg (seqid, eventid, predicted_itv, currency, value, url, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    215   �       -           0    0    add_payment_info_lg_seqid_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public.add_payment_info_lg_seqid_seq', 13, true);
          public          postgres    false    200            .           0    0    add_to_cart_lg_seqid_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.add_to_cart_lg_seqid_seq', 23, true);
          public          postgres    false    202            /           0    0    add_to_wish_list_lg_seqid_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public.add_to_wish_list_lg_seqid_seq', 10, true);
          public          postgres    false    216            0           0    0    complete_reg_lg_seqid_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.complete_reg_lg_seqid_seq', 10, true);
          public          postgres    false    204            1           0    0    init_checkout_lg_seqid_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.init_checkout_lg_seqid_seq', 10, true);
          public          postgres    false    206            2           0    0    page_view_lg_seqid_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.page_view_lg_seqid_seq', 10, true);
          public          postgres    false    208            3           0    0    products_seqid_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.products_seqid_seq', 133, true);
          public          postgres    false    210            4           0    0    purchase_lg_seqid_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.purchase_lg_seqid_seq', 10, true);
          public          postgres    false    212            5           0    0    search_lg_seqid_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.search_lg_seqid_seq', 10, true);
          public          postgres    false    218            6           0    0    subscribe_lg_seqid_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.subscribe_lg_seqid_seq', 10, true);
          public          postgres    false    214            v           2606    17060 )   add_payment_info_lg addpaymentinfolg_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public.add_payment_info_lg
    ADD CONSTRAINT addpaymentinfolg_pkey PRIMARY KEY (eventid);
 S   ALTER TABLE ONLY public.add_payment_info_lg DROP CONSTRAINT addpaymentinfolg_pkey;
       public            postgres    false    201            x           2606    17071    add_to_cart_lg addtocartlg_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.add_to_cart_lg
    ADD CONSTRAINT addtocartlg_pkey PRIMARY KEY (eventid);
 I   ALTER TABLE ONLY public.add_to_cart_lg DROP CONSTRAINT addtocartlg_pkey;
       public            postgres    false    203            �           2606    17168 (   add_to_wish_list_lg addtowishlistlg_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public.add_to_wish_list_lg
    ADD CONSTRAINT addtowishlistlg_pkey PRIMARY KEY (eventid);
 R   ALTER TABLE ONLY public.add_to_wish_list_lg DROP CONSTRAINT addtowishlistlg_pkey;
       public            postgres    false    217            z           2606    17084 $   complete_reg_lg complete_reg_lg_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public.complete_reg_lg
    ADD CONSTRAINT complete_reg_lg_pkey PRIMARY KEY (eventid);
 N   ALTER TABLE ONLY public.complete_reg_lg DROP CONSTRAINT complete_reg_lg_pkey;
       public            postgres    false    205            |           2606    17096    init_checkout_lg initcheckoutlg 
   CONSTRAINT     b   ALTER TABLE ONLY public.init_checkout_lg
    ADD CONSTRAINT initcheckoutlg PRIMARY KEY (eventid);
 I   ALTER TABLE ONLY public.init_checkout_lg DROP CONSTRAINT initcheckoutlg;
       public            postgres    false    207            ~           2606    17107    page_view_lg page_view_lg_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.page_view_lg
    ADD CONSTRAINT page_view_lg_pkey PRIMARY KEY (eventid);
 H   ALTER TABLE ONLY public.page_view_lg DROP CONSTRAINT page_view_lg_pkey;
       public            postgres    false    209            �           2606    17126    purchase_lg purchase_lg_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.purchase_lg
    ADD CONSTRAINT purchase_lg_pkey PRIMARY KEY (eventid);
 F   ALTER TABLE ONLY public.purchase_lg DROP CONSTRAINT purchase_lg_pkey;
       public            postgres    false    213            �           2606    17179    search_lg search_lg_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.search_lg
    ADD CONSTRAINT search_lg_pkey PRIMARY KEY (eventid);
 B   ALTER TABLE ONLY public.search_lg DROP CONSTRAINT search_lg_pkey;
       public            postgres    false    219            �           2606    17145    subscribe_lg subscribe_lg_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.subscribe_lg
    ADD CONSTRAINT subscribe_lg_pkey PRIMARY KEY (eventid);
 H   ALTER TABLE ONLY public.subscribe_lg DROP CONSTRAINT subscribe_lg_pkey;
       public            postgres    false    215            
     x���Mk�@���W�1�f5�����B�Mi]B!Ŗ��R	[ơ���k׺�G]��̢ه�U-��(�a�_�Y"���0����$vũi�n^��������ݦ슪š}{���ǺcȀ��<t�]�'�Z"[�25�T�X�[u�0�C��3* �X�ٷ�Q3�T�i�͟�����7���Ms:��#��`�=���lۺ|,��U�儲�f��Z|}����_��Ks�?���k�{'@h�A�F�����-�v�,P��Z��q��A�\l� �����O%�&d���蔐|q,`���0N
8����zg�K�r,^�x����v"rBf���U	X���V6("'d������6	��k9!���- }�	،l�6��4>�z`-�؎���S�"rB��{�lvc	�$쇄�Ԅ���$�WaD��~,ᐄÐ���0���$,{a�_��XI�Q���ԌiB�t�zc�aFC���:��Q�'�e�_?�	�           x���Kk�0 ��+tla3��[�a���Izh�Ћ��7�K�����h.��'à���ǌ)F��x���l����{�-�n�fi��na�o뺆y��~�E�n�z�9�E������'#�m���n�^�IQ0$!�6�y6ͫ"�##$N��@d�I���!�d�lZ�+�*O5 �z.׋z��'��aè�e�5��l��x�]��i����l:���rU���|U_�eS�����C E�)ϛ��Y<���`��%��@ҩ����	��G�9�L�LD?LHH���v�^�Dz?fw�|}分 jC�����9�Z%�<�z��4oY��j(�$2! �O��饲��)����/����z0�2D�`ꎦ�)4�ߡ��;Ұ�'5�!5�P��?�j"G�ئ��K�v0�.��&�I-zK=���sV^4u�1��D����N��P�MeO����_��M��L5D�`*N�·���Uz5��ՅG)Iԁ�����	��=*Do�q�r~ITHT	����B�$���~1           x����j�@ ���)��@=���wm��&�.���b+XD����Ч�Jv탪Kt�i�eg?��Yd	mpY����"Al�z�����p�Mv��
V�K���w�vW�_W�:����l�}�(H����O�X�3�.H,�y��J�|�����	�$�Ɓq��L���$D���xX�y��(�,5������{�XJB�'���oV_���m��珳�N�r�����.��>Ȳx���|�\]�/�]�����f�@���)��eͶO�@@c��je�R^�sM #��iBF��"M5��M��j��GT��UnU���MN4U"&����#+`UVղ�V5*V"&��J��Y� V�a�-��a�1�t!����dO/�~?�鰚�����Q�:h1�gV���,~?���ږ�����r<U�EU;k�?����ZUףjG���A��_X�>U,�^��oY}���V�pfU��x[���a-k�a�cb%"&��?�d瑇����� ��CFC�j�4��<@�$0��         �  x����N1 ��>�T&3�w���H�FU	BH\0eņE�VT}�zM�\j?�Js���`�YB�ӆ�˟��}��/#���~�������,P����ǧ�m���jwkb��&�$�6�������B�3�3"A�L�Ț͊}�H%YZ�B*v�f����va ��u��0���z#�EJX}.~Y}*>��u�[u��(ʊ��Ŧ��A��s_���p*>?�m\xZz�$.��v���6�xd1�l�V�8 �uPA;7-�()O`�%ʥ409!�G9�U��YN���<LN��A�xԾ*'�r*˩������09!�9K�rT��YN����4���圱�"��r&˙�������	�=�9+r�"g��-��9�������p��2�+��Y��w8��6�n9]�������<LN��A�K�eE�T�B��09��`rBN������V�l�.��?a�?��J����'U         �  x����j�0 ��:&Ќg�/�І�z	����uX'6k�>}�l��|3�i1�$�YB�$�f��F!@l?]�g�8��/Ƕma۾do}uȺC�{��j(�ʾ{�Ά�~L��6��mb�!I��u>��l��/�b�<"+6+vs'`�8�T�a͊�_�4ef ��]��k�^�7��RĄ՗���sq�uMuW=��!3ʁ��lu�)~M�\�_���=?����ʼ-=i˧�PKm���,Ƒ�����*h�R�DIo`�\��H�������R9��\���QB�C�&Q�D�A�&��#� �!�'�F����MT/I4�!7��&<�� g5�Ր���Q��Q�f�KM~��$jȇ��Q�Q��?u�Ͼ>�%�&@�a"�қ�I�rH-$@�'�>��[>.	5	" ��?��         �  x����k�0��W������~+=lc����2ʠ7Q��;��!e�$w�}2z'�}H�����%��Y��C��EQ\.8���i`ۼ�6���ٝ��.veUC��>~���\w��m�iȳ_)�&�I�Đ���:ت�#���(� Z�Bd�͒�x`��,�SIŞ�l����,��y���K+�Ax/҄�����[��x��c|^V]a�e���a���A��K�����_��5����4���<U����g  �i��je�R^�s9 Q���>m�lnE.��Sä���c�43N������ӄ '�T���s�4�����3�3�z��S�y��y�z����X�zRO�{�1O=3Oc!�!��gp8�}����4s������gz�������n����3�@C�C�Og������~�����A�C���P�I=C��<��<� �!'���)=��?�8FfF�<d?�O�9�(���         �  x�m�I�@ ��cF4�_���gL/ rL�d��; ~@`��#����?�j!���/̀ṡ�lrÔu�R1��aچNS1����ı���'B�\����5�Z��P�+d�[��08���0�@��dz_�Ɔ�h��-sR&�YLja�sC�z��-S64e�ljô�Ly_s��I�dNha�����ghRÜ>�C1��aʁ6U��-s�g�������q ɅZ�)6ʻ���0w!H�g���aʁ���!��iC�!����B
84ha�x�N�OE��a�B�5��p�<��rMma���,��[��z
#�k*�0�UȜx���(�0�y��IPna���(3���0mCF/�z_�Ɓ��ib��0O!�|�F-�b%�3d��0O!���n��a^���`�-|M?�dp)���0O!c�bR�<��
���[�)�B�?����i4��ӽ��I���%_�t�xQei���^��9��-]�ʤ�(0��˽R9Hu������E�=�t���T+��;��V���l2eQ�;v�˕M�,+���L�k�� (��4ܽh�(�e����r�����%�Z��yQ�2��-]���Yp��-]�Պ�={Kå��ԕZ�ܫ���gD����������9{�         �  x���Mk�0��+tL��g�1�6�����v��n	�\�]�5qj�vp误��|��0���t� CB��������B�!�c�5�*����Ǽ��Z���-NYs����PtyYɼm�>2d]�v��(�5D��vC��ƒ�m�`� %WC��n;�g`Cx(��Öm�eU噕 ���?��o�v'$܊�A�V������*��u�eV;�I\��v�oDU>�k���ŗ�~)2�$H�<H4(~�O��|_�}z�(�`82��d�D�M��8
��p+���^��������6�⬪*��)U\�*Z��Q��
IUͪ����RUKS%��U�&��YUMR5S�zy���U���[5��ڤj�T��T�����BՁN�vVUJ�4�j����Q�+pI�fUuI�M���T������*���ͪꓪ�Ru�S���è�Ϊ~VՐTÔ�_�j��8�+�{�f�<�lXlT� 9�� m��.         �  x����j�0 ��:&Ќg�3�6�6͡��.��
�8�k��f�aC���S���aNbIb� &������?T��m#o�ފ��"A웦>.��t:�>;UU��5};懴����MV����Ϣɏ͗>Q���k��LIic�� VY�
��bH�ED��,��]<���1��k���e��P^<v��(�Ix-��k���R��u�?�OˢI�v�Y^,�6��dY���[�}�.���P��w�`�G C�g����e���O@@����F�u@ڛ��q�MP��
��D�PjAZLLT�ؚ/M�:_5�Ks��jb�Ͼ����jB_���1_53_��jbbξV�_=���|͘����V�jbb{_�ð��	}m�k�|��|���p�����N�˝/��ڹ�������z_�|yB_���1_��o,m���y�Q���&����us���jbzߘ<o~B����1_?7� �o�g`F;2����`�q��A�݄{�$I��Ů�         �  x���Mk�@����c�hf��9���\�Һ�B.��`�2��C}WJ�m�Q'���Wh�a�	=�H���h -�f`ۦ�fYv<a�뺆u����}��כ�u�)��� ?��>��84�NA�+�$V��6��Y,�Č7D��,�X����]��H�Tڈ��X�˪�3����?��xP˕"�U���[�������U�}�8/�̙ ƫ���j�탪��B}-��������/E XȒ��?����g�o���<�+{o�w�Dˆmm@��L/p
�L�̴jA�Խ�CO�\�F�������:��9Ѳ�V�Hk:Z3D��F��B��=��/���v�v��L�6�@C�������9���u�n��N��R>A��'Z��i݈����C�nj����$��V���eC'�d��d#��(cOu�� �H;�8D&F�Ө�--��윻��8"-w�<D'Fk��(	O����È+��8��S�e��F���� ��     