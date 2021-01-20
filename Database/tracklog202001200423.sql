PGDMP                          y            HAWOOO_userlogs    13.0    13.0 S               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                        0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            !           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            "           1262    16394    HAWOOO_userlogs    DATABASE     u   CREATE DATABASE "HAWOOO_userlogs" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
 !   DROP DATABASE "HAWOOO_userlogs";
                postgres    false            �            1255    26358    usp_getaddtocart()    FUNCTION     �  CREATE FUNCTION public.usp_getaddtocart() RETURNS TABLE(_eventid bigint, _currency character varying, _total_value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob character varying, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
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
       public          postgres    false            �            1255    26359    usp_getaddtowishlist()    FUNCTION     �  CREATE FUNCTION public.usp_getaddtowishlist() RETURNS TABLE(_eventid bigint, _currency character varying, _value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob character varying, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
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
   FROM add_to_wish_list_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 -   DROP FUNCTION public.usp_getaddtowishlist();
       public          postgres    false            �            1255    26473    usp_getcompleteregistration()    FUNCTION       CREATE FUNCTION public.usp_getcompleteregistration() RETURNS TABLE(_eventid bigint, _content_name character varying, _reg_status character varying, _currency character varying, _total_value numeric, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob character varying, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
   RETURN QUERY
   SELECT eventid, 
   content_name,
   reg_status,
   currency,
   total_value,
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
   FROM complete_reg_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 4   DROP FUNCTION public.usp_getcompleteregistration();
       public          postgres    false            �            1255    26361    usp_getinitiatecheckout()    FUNCTION     �  CREATE FUNCTION public.usp_getinitiatecheckout() RETURNS TABLE(_eventid bigint, _currency character varying, _total_value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob character varying, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
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
   FROM init_checkout_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 0   DROP FUNCTION public.usp_getinitiatecheckout();
       public          postgres    false            �            1255    26362    usp_getpageview()    FUNCTION     Z  CREATE FUNCTION public.usp_getpageview() RETURNS TABLE(_eventid bigint, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob character varying, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
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
   FROM page_view_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 (   DROP FUNCTION public.usp_getpageview();
       public          postgres    false            �            1255    26363    usp_getpaymentinfo()    FUNCTION     �  CREATE FUNCTION public.usp_getpaymentinfo() RETURNS TABLE(_eventid bigint, _currency character varying, _value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob character varying, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
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
       public          postgres    false            �            1255    26472    usp_getpurchasedata()    FUNCTION     �  CREATE FUNCTION public.usp_getpurchasedata() RETURNS TABLE(_eventid bigint, _currency character varying, _total_value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob character varying, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
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
   FROM purchase_lg 
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 ,   DROP FUNCTION public.usp_getpurchasedata();
       public          postgres    false            �            1255    26365    usp_getsearch()    FUNCTION     �  CREATE FUNCTION public.usp_getsearch() RETURNS TABLE(_eventid bigint, _search_str text, _currency character varying, _value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob character varying, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
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
   FROM search_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 &   DROP FUNCTION public.usp_getsearch();
       public          postgres    false            �            1255    26366    usp_getsubscribe()    FUNCTION     �  CREATE FUNCTION public.usp_getsubscribe() RETURNS TABLE(_eventid bigint, _predicted_itv character varying, _currency character varying, _total_value numeric, _url text, _email character varying, _first_name character varying, _last_name character varying, _phone character varying, _gender character varying, _dob character varying, _city character varying, _state character varying, _country character varying, _user_ip character varying, _browser_user_agent character varying, _clickid character varying, _browserid character varying, _fb_loginid character varying)
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
   FROM subscribe_lg  
   WHERE status = 1 order by eventid, createtimestamp asc;  
END
$$;
 )   DROP FUNCTION public.usp_getsubscribe();
       public          postgres    false            �            1259    26372    add_payment_info_lg    TABLE     ]  CREATE TABLE public.add_payment_info_lg (
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
    dob character varying(8),
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
       public         heap    postgres    false            �            1259    26370    add_payment_info_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.add_payment_info_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE public.add_payment_info_lg_seqid_seq;
       public          postgres    false    203            #           0    0    add_payment_info_lg_seqid_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public.add_payment_info_lg_seqid_seq OWNED BY public.add_payment_info_lg.seqid;
          public          postgres    false    202            �            1259    26383    add_to_cart_lg    TABLE     ,  CREATE TABLE public.add_to_cart_lg (
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
    dob character varying(8),
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
       public         heap    postgres    false            �            1259    26381    add_to_cart_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.add_to_cart_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.add_to_cart_lg_seqid_seq;
       public          postgres    false    205            $           0    0    add_to_cart_lg_seqid_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.add_to_cart_lg_seqid_seq OWNED BY public.add_to_cart_lg.seqid;
          public          postgres    false    204            �            1259    26394    add_to_wish_list_lg    TABLE     +  CREATE TABLE public.add_to_wish_list_lg (
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
    dob character varying(8),
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
       public         heap    postgres    false            �            1259    26392    add_to_wish_list_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.add_to_wish_list_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE public.add_to_wish_list_lg_seqid_seq;
       public          postgres    false    207            %           0    0    add_to_wish_list_lg_seqid_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public.add_to_wish_list_lg_seqid_seq OWNED BY public.add_to_wish_list_lg.seqid;
          public          postgres    false    206            �            1259    26405    complete_reg_lg    TABLE     \  CREATE TABLE public.complete_reg_lg (
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
    dob character varying(8),
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
       public         heap    postgres    false            �            1259    26403    complete_reg_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.complete_reg_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public.complete_reg_lg_seqid_seq;
       public          postgres    false    209            &           0    0    complete_reg_lg_seqid_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public.complete_reg_lg_seqid_seq OWNED BY public.complete_reg_lg.seqid;
          public          postgres    false    208            �            1259    26417    init_checkout_lg    TABLE       CREATE TABLE public.init_checkout_lg (
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
    dob character varying(8),
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
       public         heap    postgres    false            �            1259    26415    init_checkout_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.init_checkout_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.init_checkout_lg_seqid_seq;
       public          postgres    false    211            '           0    0    init_checkout_lg_seqid_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.init_checkout_lg_seqid_seq OWNED BY public.init_checkout_lg.seqid;
          public          postgres    false    210            �            1259    26428    page_view_lg    TABLE     �  CREATE TABLE public.page_view_lg (
    seqid integer NOT NULL,
    eventid bigint NOT NULL,
    url text,
    email character varying(500),
    first_name character varying(50),
    last_name character varying(50),
    phone character varying(50),
    gender character varying(6),
    dob character varying(8),
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
       public         heap    postgres    false            �            1259    26426    page_view_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.page_view_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.page_view_lg_seqid_seq;
       public          postgres    false    213            (           0    0    page_view_lg_seqid_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.page_view_lg_seqid_seq OWNED BY public.page_view_lg.seqid;
          public          postgres    false    212            �            1259    17110    products    TABLE     �   CREATE TABLE public.products (
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
       public          postgres    false    201            )           0    0    products_seqid_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.products_seqid_seq OWNED BY public.products.seqid;
          public          postgres    false    200            �            1259    26439    purchase_lg    TABLE     )  CREATE TABLE public.purchase_lg (
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
    dob character varying(8),
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
       public         heap    postgres    false            �            1259    26437    purchase_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.purchase_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.purchase_lg_seqid_seq;
       public          postgres    false    215            *           0    0    purchase_lg_seqid_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.purchase_lg_seqid_seq OWNED BY public.purchase_lg.seqid;
          public          postgres    false    214            �            1259    26450 	   search_lg    TABLE     $  CREATE TABLE public.search_lg (
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
    dob character varying(8),
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
       public         heap    postgres    false            �            1259    26448    search_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.search_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public.search_lg_seqid_seq;
       public          postgres    false    217            +           0    0    search_lg_seqid_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public.search_lg_seqid_seq OWNED BY public.search_lg.seqid;
          public          postgres    false    216            �            1259    26461    subscribe_lg    TABLE     ;  CREATE TABLE public.subscribe_lg (
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
    dob character varying(8),
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
       public         heap    postgres    false            �            1259    26459    subscribe_lg_seqid_seq    SEQUENCE     �   CREATE SEQUENCE public.subscribe_lg_seqid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.subscribe_lg_seqid_seq;
       public          postgres    false    219            ,           0    0    subscribe_lg_seqid_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.subscribe_lg_seqid_seq OWNED BY public.subscribe_lg.seqid;
          public          postgres    false    218            l           2604    26375    add_payment_info_lg seqid    DEFAULT     �   ALTER TABLE ONLY public.add_payment_info_lg ALTER COLUMN seqid SET DEFAULT nextval('public.add_payment_info_lg_seqid_seq'::regclass);
 H   ALTER TABLE public.add_payment_info_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    202    203    203            m           2604    26386    add_to_cart_lg seqid    DEFAULT     |   ALTER TABLE ONLY public.add_to_cart_lg ALTER COLUMN seqid SET DEFAULT nextval('public.add_to_cart_lg_seqid_seq'::regclass);
 C   ALTER TABLE public.add_to_cart_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    204    205    205            n           2604    26397    add_to_wish_list_lg seqid    DEFAULT     �   ALTER TABLE ONLY public.add_to_wish_list_lg ALTER COLUMN seqid SET DEFAULT nextval('public.add_to_wish_list_lg_seqid_seq'::regclass);
 H   ALTER TABLE public.add_to_wish_list_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    207    206    207            o           2604    26408    complete_reg_lg seqid    DEFAULT     ~   ALTER TABLE ONLY public.complete_reg_lg ALTER COLUMN seqid SET DEFAULT nextval('public.complete_reg_lg_seqid_seq'::regclass);
 D   ALTER TABLE public.complete_reg_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    209    208    209            p           2604    26420    init_checkout_lg seqid    DEFAULT     �   ALTER TABLE ONLY public.init_checkout_lg ALTER COLUMN seqid SET DEFAULT nextval('public.init_checkout_lg_seqid_seq'::regclass);
 E   ALTER TABLE public.init_checkout_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    210    211    211            q           2604    26431    page_view_lg seqid    DEFAULT     x   ALTER TABLE ONLY public.page_view_lg ALTER COLUMN seqid SET DEFAULT nextval('public.page_view_lg_seqid_seq'::regclass);
 A   ALTER TABLE public.page_view_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    212    213    213            k           2604    17113    products seqid    DEFAULT     p   ALTER TABLE ONLY public.products ALTER COLUMN seqid SET DEFAULT nextval('public.products_seqid_seq'::regclass);
 =   ALTER TABLE public.products ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    201    200    201            r           2604    26442    purchase_lg seqid    DEFAULT     v   ALTER TABLE ONLY public.purchase_lg ALTER COLUMN seqid SET DEFAULT nextval('public.purchase_lg_seqid_seq'::regclass);
 @   ALTER TABLE public.purchase_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    214    215    215            s           2604    26453    search_lg seqid    DEFAULT     r   ALTER TABLE ONLY public.search_lg ALTER COLUMN seqid SET DEFAULT nextval('public.search_lg_seqid_seq'::regclass);
 >   ALTER TABLE public.search_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    216    217    217            t           2604    26464    subscribe_lg seqid    DEFAULT     x   ALTER TABLE ONLY public.subscribe_lg ALTER COLUMN seqid SET DEFAULT nextval('public.subscribe_lg_seqid_seq'::regclass);
 A   ALTER TABLE public.subscribe_lg ALTER COLUMN seqid DROP DEFAULT;
       public          postgres    false    218    219    219                      0    26372    add_payment_info_lg 
   TABLE DATA           %  COPY public.add_payment_info_lg (seqid, eventid, currency, value, url, type, credit_points, pay_method, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    203   ��                 0    26383    add_to_cart_lg 
   TABLE DATA             COPY public.add_to_cart_lg (seqid, eventid, currency, total_value, url, type, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    205   ݜ                 0    26394    add_to_wish_list_lg 
   TABLE DATA           
  COPY public.add_to_wish_list_lg (seqid, eventid, currency, value, url, type, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    207   �                 0    26405    complete_reg_lg 
   TABLE DATA             COPY public.complete_reg_lg (seqid, eventid, content_name, reg_status, currency, total_value, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    209   0�                 0    26417    init_checkout_lg 
   TABLE DATA             COPY public.init_checkout_lg (seqid, eventid, currency, total_value, url, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    211   &�                 0    26428    page_view_lg 
   TABLE DATA           �   COPY public.page_view_lg (seqid, eventid, url, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    213   �       
          0    17110    products 
   TABLE DATA           G   COPY public.products (seqid, eventid, productid, quantity) FROM stdin;
    public          postgres    false    201   צ                 0    26439    purchase_lg 
   TABLE DATA             COPY public.purchase_lg (seqid, eventid, currency, total_value, url, type, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    215   m�                 0    26450 	   search_lg 
   TABLE DATA             COPY public.search_lg (seqid, eventid, search_str, currency, value, url, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    217   d�                 0    26461    subscribe_lg 
   TABLE DATA             COPY public.subscribe_lg (seqid, eventid, predicted_itv, currency, value, url, email, first_name, last_name, phone, gender, dob, city, state, country, browser_sessionid, user_ip, browser_user_agent, clickid, browserid, fb_loginid, createtimestamp, status) FROM stdin;
    public          postgres    false    219   f�       -           0    0    add_payment_info_lg_seqid_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public.add_payment_info_lg_seqid_seq', 1, false);
          public          postgres    false    202            .           0    0    add_to_cart_lg_seqid_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.add_to_cart_lg_seqid_seq', 1, false);
          public          postgres    false    204            /           0    0    add_to_wish_list_lg_seqid_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public.add_to_wish_list_lg_seqid_seq', 1, false);
          public          postgres    false    206            0           0    0    complete_reg_lg_seqid_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.complete_reg_lg_seqid_seq', 1, false);
          public          postgres    false    208            1           0    0    init_checkout_lg_seqid_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.init_checkout_lg_seqid_seq', 1, false);
          public          postgres    false    210            2           0    0    page_view_lg_seqid_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.page_view_lg_seqid_seq', 1, false);
          public          postgres    false    212            3           0    0    products_seqid_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.products_seqid_seq', 133, true);
          public          postgres    false    200            4           0    0    purchase_lg_seqid_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.purchase_lg_seqid_seq', 1, false);
          public          postgres    false    214            5           0    0    search_lg_seqid_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.search_lg_seqid_seq', 1, false);
          public          postgres    false    216            6           0    0    subscribe_lg_seqid_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.subscribe_lg_seqid_seq', 1, false);
          public          postgres    false    218            v           2606    26380 )   add_payment_info_lg addpaymentinfolg_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public.add_payment_info_lg
    ADD CONSTRAINT addpaymentinfolg_pkey PRIMARY KEY (eventid);
 S   ALTER TABLE ONLY public.add_payment_info_lg DROP CONSTRAINT addpaymentinfolg_pkey;
       public            postgres    false    203            x           2606    26391    add_to_cart_lg addtocartlg_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.add_to_cart_lg
    ADD CONSTRAINT addtocartlg_pkey PRIMARY KEY (eventid);
 I   ALTER TABLE ONLY public.add_to_cart_lg DROP CONSTRAINT addtocartlg_pkey;
       public            postgres    false    205            z           2606    26402 (   add_to_wish_list_lg addtowishlistlg_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public.add_to_wish_list_lg
    ADD CONSTRAINT addtowishlistlg_pkey PRIMARY KEY (eventid);
 R   ALTER TABLE ONLY public.add_to_wish_list_lg DROP CONSTRAINT addtowishlistlg_pkey;
       public            postgres    false    207            |           2606    26413 $   complete_reg_lg complete_reg_lg_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public.complete_reg_lg
    ADD CONSTRAINT complete_reg_lg_pkey PRIMARY KEY (eventid);
 N   ALTER TABLE ONLY public.complete_reg_lg DROP CONSTRAINT complete_reg_lg_pkey;
       public            postgres    false    209            ~           2606    26425    init_checkout_lg initcheckoutlg 
   CONSTRAINT     b   ALTER TABLE ONLY public.init_checkout_lg
    ADD CONSTRAINT initcheckoutlg PRIMARY KEY (eventid);
 I   ALTER TABLE ONLY public.init_checkout_lg DROP CONSTRAINT initcheckoutlg;
       public            postgres    false    211            �           2606    26436    page_view_lg page_view_lg_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.page_view_lg
    ADD CONSTRAINT page_view_lg_pkey PRIMARY KEY (eventid);
 H   ALTER TABLE ONLY public.page_view_lg DROP CONSTRAINT page_view_lg_pkey;
       public            postgres    false    213            �           2606    26447    purchase_lg purchase_lg_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.purchase_lg
    ADD CONSTRAINT purchase_lg_pkey PRIMARY KEY (eventid);
 F   ALTER TABLE ONLY public.purchase_lg DROP CONSTRAINT purchase_lg_pkey;
       public            postgres    false    215            �           2606    26458    search_lg search_lg_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.search_lg
    ADD CONSTRAINT search_lg_pkey PRIMARY KEY (eventid);
 B   ALTER TABLE ONLY public.search_lg DROP CONSTRAINT search_lg_pkey;
       public            postgres    false    217            �           2606    26469    subscribe_lg subscribe_lg_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.subscribe_lg
    ADD CONSTRAINT subscribe_lg_pkey PRIMARY KEY (eventid);
 H   ALTER TABLE ONLY public.subscribe_lg DROP CONSTRAINT subscribe_lg_pkey;
       public            postgres    false    219               %  x����k�0��W���*���/=lc����e�A/n�Sw�C���Ir�\���-0	��_D������,����<� b����'y~<Ŧ86M#��k~ؗ�|�kV�e�*ۢ�E�߾��\��C�2d�ܷ.��ϰkNl��J��u�ج�K�D��f�)���0�bOs6k�Tu]�F �y�~����A�=V��7�o����.��i��F9�,��>,f_��z)��r����O�]�Z��	Zz���(�Ů:m��]?h!��Z��q�פH;H�xx���� LE4����jH��IU�j���S�#WuC�E4��K��+Ŋ�\ã�Fەk8���tv-�L�v(W�X]���U�"�L���#H�8��L��OG����
n��^+:����T'S�g���Ԡ��23gU�qIU�����S�נ����2�
�ے�J�&UۧjF��uUn�V���������'V��ꮂՋh(3unʓ6�h5P��U*�5t ����V�%�zp�E ���Y�l�X���2{Y��7���           x����j�0��Z�0�u���b�t`�t15�B7n�NL�(�.)��#��l��7ᅐ���#�#��k� ,$��?�9`Αe�o�"Ϸ�-[V�������m�i��c�/|_�����w��]�㴔L��/)����B*m�#������ ��4��3��@A^�,��������^/¶�%��-�Z��O-���f��'�:��\	Ä�W���l��6���_~�
��~نw�[�8�h9	��z��z�Z���+����Z
�a�N� G��p�rS�-�e	3�GGÝ���dX֗ ��!]!8Kj���CJ#����@Ϊ��qQ�D��"�: r)����sB������"煌Yä�p�i\})��w�<��RM�qC��V,�EH<Aڸ�d��@qL����,#��3Z�RM�CM;+����4����¨G���,�EG�w���Æ�j�:��?�F�#vԅ���Т�9�NHs�9�@y�5�2Ξ�y E,���(���"گcq�����m=��q䐮�Ȓf/,˲�i�i�           x���Mo�@���+��H�03�Mm�C#����UT)b�)�M䨿�v�N��i����WXA����C1��C��������x�M~��
V�K�z(��n_�_W����r�a��Q���Cm?u��W�]X�l�+m��A��m!(DC$�˙�~�q"^���B̫��v��P^ݗ��� KIx+�շ���k�y����㬬S�(+�fw���r[>�k�z���;z)R� A�G M�g�����cͶO�@@�{Z��5HyT��5�L7H7d$�9C��'�BI�Ο(Ux?��Q�RS��))3�B�Ke�mk���г�e��S��4r�������Ka�=Kn-yؒ�nI�6��q⻺��TkIcr�{����Önꖱ.=4r��1����I�ӌ�,�;Þa➬2�����u��Ξ:3�N��t-����l�������:3~��ߢ����AJ��4L�2V&��(�:Io΍9*��G�ZJ5�J5�TFJ�mL��a:M���-M�Ҵ�f�RO�2N4r�<@�$� !6wm         �  x���Mk1��+tL�ό��KK�6%q	�\6��,Yg��%����%�/k�7���F�a^!'�����P\�~}m�Mz��6��w]ڦ���#�(���>?Uom��}�?wi�rb���@bm��!�e�$A1":"�\/ď�\G�y��+�l��MS�,�:��_ڷ�Z�!��Μ�?Μ�/�V�:�-�nf�����b���I5�sR���s{��>m�M��RW�c��߷��>�9��t�hg=�&�h��02�!��U��s��`I{-c�RA+�q-�h\����z���\��P�2��
W�
��z���e�Y�.?p�q.���{�?W�O�/q�W.3�G�����|3���Ji���z��ˌ�����A��R�l@S��\z���\z�\:@��2�s��-�1\q�+N�Kg1�qX�C�u��E.;p�q.;u�F=K>|�B�F}��.���sq���-H)����         �  x����j�0 ��:�Ў5���Ж=l!MXv���^�D%�nmb�}��Ҳ��d��1҇4�chQ����V~�� ����[�0�/��i`ۼ�]<��ٽo�]�˪��k?�Y��fd�S�ڱMfIic]NP֑aSc�͒��KYY�H�{\�U��0 ��C��k�N�7%�+���V��۶��C|ZV}a�e���n���u����}i�ŷ��y��w A���ů�<T_�r��'@@+�:�����*h�r I�K��h��ri ��#���'c�3gԐш��H��##��i��������R��3*�h��?#���1mr2G���]Y��?yc������LV#FGK�L�f�h!��'���OǠ'c�3gT��Ry�'����>ʙKZ�l�����g�4���9���F�8�� �Hp         �  x���Mk�@����c�hf��9���\�B]B!Ŗ��R[ơ���J�/:�bk�e�;������ŀދM�m���8��)�m�²}-�jWlw���VUW�����ǯպ<4��}��\/~��9�X���Abm��!�Y�T�b��1[Lŏ1�-REzY������)�n�?���W�"�WiÙ{��̭���6�c�<���jک���b���j�J}��/����ٵ�U< dH�,���ߖ�]?9L����z L��$�T��t�tGVa� Mt���Ҟ��`Fe���B4���� ������1*"��<�H׀h2�pBtޚqob����|D���L�2�=�	�"�1!�k@$�L�Ҝ�9���"��!��GL�!����N����xB�k@�.��t�p�yTC��!C{�6B&c���lcQ��z���X�d,�9�����~�]>b
g���H)�l!xA      
   �  x�m�I�@ ��cF4�_���gL/ rL�d��; ~@`��#����?�j!���/̀ṡ�lrÔu�R1��aچNS1����ı���'B�\����5�Z��P�+d�[��08���0�@��dz_�Ɔ�h��-sR&�YLja�sC�z��-S64e�ljô�Ly_s��I�dNha�����ghRÜ>�C1��aʁ6U��-s�g�������q ɅZ�)6ʻ���0w!H�g���aʁ���!��iC�!����B
84ha�x�N�OE��a�B�5��p�<��rMma���,��[��z
#�k*�0�UȜx���(�0�y��IPna���(3���0mCF/�z_�Ɓ��ib��0O!�|�F-�b%�3d��0O!���n��a^���`�-|M?�dp)���0O!c�bR�<��
���[�)�B�?����i4��ӽ��I���%_�t�xQei���^��9��-]�ʤ�(0��˽R9Hu������E�=�t���T+��;��V���l2eQ�;v�˕M�,+���L�k�� (��4ܽh�(�e����r�����%�Z��yQ�2��-]���Yp��-]�Պ�={Kå��ԕZ�ܫ���gD����������9{�         �  x����j1 г�:&��jF�Hrm�צ�.������%���78�뻒C����B'1b�C�
d�C. ���"F�Ql�nw���x�myl���K�z���n�n^�ݦ�ʺ��{�(Ptա�t���%�U�B#�؇(eS	�Qc��b5���Ģ��7���o�4e�@����Ϧ=�r�P��U��[���Z}���z��]���j~�Z|�����R_��s{��l��KU,hQ�,��}�~-�}zdݿ��v�M�ާ ҄7o�)fdf�Ar#��K�@�gI��gJ?D�S�� 	�$�)�w.S⨔�)i�'A� ���3���dJ7*%gJ�t�����H�3%��ҌJi3��4��dHp$�2"�
<�J3e������H�����D�G��2Q�IPHp$�E����F�4��Q�$(I������QK}�,��f��f�DG�]4q��Ǵ�b�l�(�$(=$8� ����v�         �  x���Ak�0��)tla}���')=l]+d	e�(�^��%��l��}�I���'�A��3?�I�$IA�y�#�?4��m�o�޲���{޳}׵�E��N'���i`ۼ�o��-��+��c���u��2�_�p-ۄ���6d�g��.�cdx�j�d�wa2�E��l�����~�P��5�#_o� �y8 }��I_򛶭ˇ�iYu�Q���f������+�/�%����2wht���g�\��mq��H�$�iEƂTN{嵵� �+!����-Z@DČά���#V3!+���B5s@U�3yFUF�TV���GRS�b��@�SOfT9!*���B��@�	1s��;���	Q]��R�v��A$����%n*=!��QM
U�U���)uF�$i��8!��QU
瀊អ��vH�U(F�4!��Qm
��[cP�`����TMh�{S�2U�0E����5�Q݄��G�)T7T�G}�,���i��           x����k�0�g���c�|w�N��a{X!K[F��M\b��!qI�_?��~�Kbq��}e�BF`�Q����%��&��(bDԲi��Q��v;�,vu]�y���n�M��ԋ�y�(��Z�b�~���r�|:�_�p*j��E�u�C5)V�B���Q��X}�K}U�H��z��I��Z����W�՟E����L#��i�ݭ~cw�?�׫�|WM�m0����n6��A���R-��������/e��(�A��g�Tl����m�dH�dv�}0h�+.��������8"YoZ=�x��0{�=���>O	��p�{N/�1'�i;N��I��	#/�գ�w9ٟ2 h�ӊ�W��?iJ��$���L�1��u����^'�i�(�4<�!񀞡�}�|	�M�����(ў~���ǽ�Οڴ�������1g�3v���3��'�(ŝ���qG�'�n@O�y�>Ow	���et�0#{„�yR�'��g�0�i�({0Y���|     