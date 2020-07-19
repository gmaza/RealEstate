import React, { useState, useEffect, useRef } from 'react';
import { SearchBar } from '../../components/searchBar';
import { Listings } from '../../api/service';
import { Container, Grid, useMediaQuery } from '@material-ui/core';
import { useHistory } from 'react-router-dom';
import { Pagination } from '@material-ui/lab';
import { ListingCard } from '../../components/listingCard';
import mapboxgl from 'mapbox-gl';

console.log(process.env.REACT_APP_MAPBOX_API_KEY);

mapboxgl.accessToken = process.env.REACT_APP_MAPBOX_API_KEY;

export const Search = (props) => {
    const history = useHistory();

    const [lookupOptions, setLookupOptions] = useState();
    const [listings, setListings] = useState();
    const [mapMode, setMapMode] = useState(true);
    const [mapState, setMapState] = useState({
        lng: 5,
        lat: 34,
        zoom: 2,
    });
    const [page, setPage] = useState(1);

    const mapContainerRef = useRef(null);

    useEffect(() => {
        Listings.getListingsForLP().then((response) => {
            setLookupOptions(response.lookup);
            setListings({
                items: response.latestListings,
                pageCount: response.pageCount,
            });
            const map = new mapboxgl.Map({
                container: mapContainerRef.current,
                style: 'mapbox://styles/mapbox/streets-v11',
                center: [mapState.lng, mapState.lat],
                zoom: mapState.zoom,
            });

            map.fitBounds([
                [12.2401111182, 48.5553052842],
                [18.8531441586, 51.1172677679],
            ]);
        });
    }, []);

    function handlePageChange(event, newPage) {
        setPage(newPage);
        history.push({
            search: newPage === 1 ? '' : `?page=${newPage}`,
        });
        Listings.getListingsForLP().then((response) => {
            setListings({
                items: response.latestListings,
                pageCount: response.pageCount,
            });

            window.scrollTo(0);
        });
    }
    return (
        <div>
            {lookupOptions && listings && (
                <React.Fragment>
                    <SearchBar lookupOptions={lookupOptions} />
                    <Container maxWidth={mapMode ? false : 'lg'}>
                        <Grid container spacing={2}>
                            <Grid container spacing={2} item xs={12} lg={5}>
                                {listings.items.map((x) => (
                                    <Grid
                                        item
                                        xs={12}
                                        sm={6}
                                        md={4}
                                        lg={6}
                                        key={x.id}
                                    >
                                        <ListingCard />
                                    </Grid>
                                ))}
                                <Grid container justify="center">
                                    <Pagination
                                        style={{
                                            margin: '20px 0',
                                        }}
                                        page={page}
                                        onChange={handlePageChange}
                                        count={listings.pageCount}
                                        color="secondary"
                                        variant="outlined"
                                    />
                                </Grid>
                            </Grid>
                            <Grid item xs={12} lg={7}>
                                <div
                                    ref={mapContainerRef}
                                    style={{
                                        position: 'sticky',
                                        top: '60px',
                                        height: 'calc(100vh - 100px)',
                                    }}
                                ></div>
                            </Grid>
                        </Grid>
                    </Container>
                </React.Fragment>
            )}
        </div>
    );
};
