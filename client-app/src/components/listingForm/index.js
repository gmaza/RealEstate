import React, { useState, useEffect } from 'react';
import { Grid, Box } from '@material-ui/core';
import { FormCard, Step } from './style';
import { FormStepArrowIcon } from '../icons';
import { Information } from './information';
import { Description } from './description';
import { Listings } from '../../api/service';
import { Publish } from './publish';

export const ListingForm = (props) => {
    const [step, setStep] = useState(1);
    const [formData, setFormData] = useState(null);

    useEffect(() => {
        Listings.getListingFormData(props.id).then((response) => {
            setFormData(response);
            console.log(response);
        });
    }, []);

    const stepProps = { formData, handleChange, setStep };

    function handleChange(name, value) {
        setFormData({ ...formData, [name]: value });
    }

    function getStep() {
        if (!formData) return;
        switch (step) {
            case 1:
                return <Information {...stepProps} />;
            case 2:
                return <Description {...stepProps} />;
            case 3:
                return <Publish {...stepProps} />;
            default:
                return <Information {...stepProps} />;
        }
    }

    return (
        <FormCard>
            <Box
                component={Grid}
                container
                direction="row"
                justify="space-between"
                alignItems="baseline"
                wrap="nowrap"
                px={2}
                pb={2}
            >
                <Grid item>
                    <Step className={step === 1 ? 'active-step' : ''}>
                        <Box display={{ 'xs': 'none', 'lg': 'inline' }}>
                            Property&nbsp;
                        </Box>
                        Information
                    </Step>
                </Grid>
                <Grid item>
                    <FormStepArrowIcon />
                </Grid>
                <Grid item>
                    <Step className={step === 2 ? 'active-step' : ''}>
                        <Box display={{ 'xs': 'none', 'lg': 'inline' }}>
                            Add &nbsp;
                        </Box>
                        Description
                    </Step>
                </Grid>
                <Grid item>
                    <FormStepArrowIcon />
                </Grid>
                <Grid item>
                    <Step className={step === 3 ? 'active-step' : ''}>
                        <Box display={{ 'xs': 'none', 'lg': 'inline' }}>
                            Ready to &nbsp;
                        </Box>
                        Publish
                    </Step>
                </Grid>
            </Box>
            {getStep()}
        </FormCard>
    );
};
