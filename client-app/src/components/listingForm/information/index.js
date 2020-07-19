import React from 'react';
import { Grid, InputAdornment, Box } from '@material-ui/core';
import {
    StyledSelect,
    StyledFormControl,
    StyledOutlinedInput,
    StyledButton,
} from '../../globals';
import {
    DropdownIcon,
    OfferTypeIcon,
    PropertyTypeIcon,
    PropertyLayoutIcon,
    AreaIcon,
    LocationIcon,
    LongArrowRightIcon,
} from '../../icons';
import { NavButton } from '../style';

export const Information = (props) => {
    const fieldOptions = props.formData.fieldOptions;

    console.log(props);

    return (
        <Grid container spacing={2}>
            <Grid item xs={12}>
                <StyledFormControl variant="outlined" fullWidth>
                    <StyledSelect
                        native
                        value={props.formData.offerTypeId || ''}
                        startAdornment={
                            <InputAdornment position="start">
                                <OfferTypeIcon />
                            </InputAdornment>
                        }
                        onChange={(event) =>
                            props.handleChange(
                                'offerTypeId',
                                event.target.value
                            )
                        }
                        IconComponent={DropdownIcon}
                    >
                        <option value="" disabled>
                            Offer Type
                        </option>
                        {fieldOptions.offerTypes.map((opt) => (
                            <option key={opt.id} value={opt.id}>
                                {opt.name}
                            </option>
                        ))}
                    </StyledSelect>
                </StyledFormControl>
            </Grid>

            <Grid item xs={12}>
                <StyledFormControl variant="outlined" fullWidth>
                    <StyledSelect
                        native
                        value={props.formData.propertyTypeId || ''}
                        startAdornment={
                            <InputAdornment position="start">
                                <PropertyTypeIcon />
                            </InputAdornment>
                        }
                        onChange={(event) =>
                            props.handleChange(
                                'propertyTypeId',
                                event.target.value
                            )
                        }
                        IconComponent={DropdownIcon}
                    >
                        <option value="" disabled>
                            Property Type
                        </option>
                        {fieldOptions.propertyTypes.map((opt) => (
                            <option key={opt.id} value={opt.id}>
                                {opt.name}
                            </option>
                        ))}
                    </StyledSelect>
                </StyledFormControl>
            </Grid>

            <Grid item xs={12}>
                <StyledFormControl variant="outlined" fullWidth>
                    <StyledSelect
                        native
                        value={props.formData.propeprtyLayoutId || ''}
                        startAdornment={
                            <InputAdornment position="start">
                                <PropertyLayoutIcon />
                            </InputAdornment>
                        }
                        onChange={(event) =>
                            props.handleChange(
                                'propeprtyLayoutId',
                                event.target.value
                            )
                        }
                        IconComponent={DropdownIcon}
                    >
                        <option value="" disabled>
                            Property Layout
                        </option>
                        {fieldOptions.propertyLayouts.map((opt) => (
                            <option key={opt.id} value={opt.id}>
                                {opt.name}
                            </option>
                        ))}
                    </StyledSelect>
                </StyledFormControl>
            </Grid>

            <Grid item xs={12}>
                <StyledOutlinedInput
                    placeholder="Floor Space"
                    type="number"
                    startAdornment={
                        <InputAdornment>
                            <AreaIcon />
                        </InputAdornment>
                    }
                    endAdornment={
                        <InputAdornment>
                            m<sup>2</sup>
                        </InputAdornment>
                    }
                    value={props.formData.area || ''}
                    onChange={(event) =>
                        props.handleChange('area', event.target.value)
                    }
                />
            </Grid>

            <Grid item xs={12} container direction="row" wrap="nowrap">
                <Box width={1} mr={2}>
                    <StyledOutlinedInput
                        placeholder="Address"
                        startAdornment={
                            <InputAdornment>
                                <LocationIcon />
                            </InputAdornment>
                        }
                    />
                </Box>
                <Box minWidth="56px">
                    <StyledButton variant="primary">
                        <LocationIcon fill="#fff" />
                    </StyledButton>
                </Box>
            </Grid>

            <Grid item container spacing={2}>
                <Grid item xs={6}>
                    <NavButton variant="previous">Home Page</NavButton>
                </Grid>
                <Grid item xs={6}>
                    <NavButton variant="next" onClick={() => props.setStep(2)}>
                        Continue &nbsp;
                        <LongArrowRightIcon />
                    </NavButton>
                </Grid>
            </Grid>
        </Grid>
    );
};
