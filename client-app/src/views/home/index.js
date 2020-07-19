import React, { useEffect, useState, useRef } from 'react';
import { SearchBar } from '../../components/searchBar';
import {
    Section,
    SectionHeader,
    Title,
    NumberOfListings,
    SeeMore,
    SwiperContainer,
} from './style';
import { Listings } from '../../api/service';
import { ListingCard } from '../../components/listingCard';
import { VipIcon, LongArrowRightIcon, HotIcon } from '../../components/icons';
import { FlexRow } from '../../components/globals';
import { Grid, Container, useMediaQuery } from '@material-ui/core';
import { useTheme } from '@material-ui/core/styles';
import { Pagination } from '@material-ui/lab';
import { useHistory } from 'react-router-dom';
import SwiperCore, { Pagination as SwiperPagination } from 'swiper';
import { Swiper, SwiperSlide } from 'swiper/react';
import 'swiper/swiper.scss';
import 'swiper/components/pagination/pagination.scss';

SwiperCore.use([SwiperPagination]);

export const Home = () => {
    const history = useHistory();
    const query = new URLSearchParams(window.location.search);
    const [page, setPage] = useState(parseInt(query.get('page') || '1'));
    const [lookupOptions, setLookupOptions] = useState();
    const [vipListings, setVipListings] = useState();
    const [hotListings, setHotListings] = useState();
    const [latestListings, setLatestListings] = useState();
    const latestListingsRef = useRef(null);

    const theme = useTheme();
    const isLargeScreen = useMediaQuery(theme.breakpoints.up('sm'), {
        noSsr: true,
    });

    useEffect(() => {
        console.log('useEffect');
        console.log(isLargeScreen);
        Listings.getListingsForLP({ pageSize: isLargeScreen ? 8 : 4 }).then(
            (response) => {
                setLookupOptions(response.lookup);
                setVipListings(response.vipListings);
                setHotListings(response.hotListings);
                setLatestListings({
                    listings: response.latestListings,
                    pageCount: response.pageCount,
                });
            }
        );
    }, []);

    const params = {
        pagination: { clickable: true },
        spaceBetween: 24,
        slidesPerView: 1.2,
        breakpoints: {
            600: {
                slidesPerView: 2,
            },
            960: {
                slidesPerView: 3,
                pagination: false,
            },
            1280: {
                slidesPerView: 4,
                pagination: false,
            },
        },
    };

    function loaded() {
        return lookupOptions && vipListings && hotListings && latestListings;
    }

    function handlePageChange(event, newPage) {
        setPage(newPage);
        history.push({
            search: newPage === 1 ? '' : `?page=${newPage}`,
        });
        Listings.getListingsForLP({
            page: newPage,
            pageSize: isLargeScreen ? 8 : 4,
        }).then((response) => {
            setLatestListings({
                listings: response.latestListings,
                pageCount: response.pageCount,
            });

            window.scrollTo(0, latestListingsRef.current.offsetTop - 60);
        });
    }

    return (
        <React.Fragment>
            {loaded() && (
                <React.Fragment>
                    <SearchBar lookupOptions={lookupOptions} withBackground />

                    <Container fixed>
                        <Section variant="vip">
                            <SectionHeader>
                                <FlexRow>
                                    <VipIcon />
                                    <Title>VIP Listings </Title>
                                    <NumberOfListings>
                                        <span>|</span>2800
                                    </NumberOfListings>
                                </FlexRow>

                                <SeeMore variant="vip">
                                    <span>See More</span>
                                    <LongArrowRightIcon />
                                </SeeMore>
                            </SectionHeader>
                            <SwiperContainer>
                                <Swiper {...params}>
                                    {vipListings.map((x) => (
                                        <SwiperSlide key={x.id}>
                                            <ListingCard variant="vip" />
                                        </SwiperSlide>
                                    ))}
                                </Swiper>
                            </SwiperContainer>
                        </Section>

                        <Section variant="hot">
                            <SectionHeader>
                                <FlexRow>
                                    <HotIcon />
                                    <Title>HOT Listings </Title>
                                    <NumberOfListings>
                                        <span>|</span>300
                                    </NumberOfListings>
                                </FlexRow>

                                <SeeMore variant="hot">
                                    <span>See More</span>
                                    <LongArrowRightIcon />
                                </SeeMore>
                            </SectionHeader>
                            <SwiperContainer>
                                <Swiper {...params}>
                                    {hotListings.map((x) => (
                                        <SwiperSlide key={x.id}>
                                            <ListingCard variant="hot" />
                                        </SwiperSlide>
                                    ))}
                                </Swiper>
                            </SwiperContainer>
                        </Section>

                        <Section ref={latestListingsRef}>
                            <SectionHeader>
                                <FlexRow>
                                    <Title style={{ marginLeft: 0 }}>
                                        Latest Listings
                                    </Title>
                                    <NumberOfListings>
                                        <span>|</span>4959
                                    </NumberOfListings>
                                </FlexRow>
                            </SectionHeader>

                            <Grid container spacing={3}>
                                {latestListings.listings.map((x) => (
                                    <Grid
                                        item
                                        xs={12}
                                        sm={6}
                                        md={4}
                                        lg={3}
                                        key={x.id}
                                    >
                                        <ListingCard />
                                    </Grid>
                                ))}
                            </Grid>
                            <Grid container justify="center">
                                <Pagination
                                    style={{
                                        margin: '20px 0',
                                    }}
                                    page={page}
                                    onChange={handlePageChange}
                                    count={latestListings.pageCount}
                                    color="secondary"
                                    variant="outlined"
                                />
                            </Grid>
                        </Section>
                    </Container>
                </React.Fragment>
            )}
        </React.Fragment>
    );
};
