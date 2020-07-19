import React from 'react';
import { Typography, Box, Container } from '@material-ui/core';
import { ListingForm } from '../../components/listingForm';

export const AddListing = () => {
    return (
        <Container maxWidth="md">
            <Box component={Typography} variant="h1" pt={3}>
                Add Your Property
            </Box>
            <Box component={Typography} variant="subtitle1" pt={1} pb={2}>
                Inserting and activating the advertisement will not take you
                more than 5 minutes, including registration.
            </Box>

            <ListingForm></ListingForm>
        </Container>
    );
};
